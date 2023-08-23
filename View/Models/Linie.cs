using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Models
{
    internal class Linie : Figura
    {

        private Punct punct1;
        private Punct punct2;

        public Linie(Punct punct1, Punct punct2,string name):base(name)
        {
            this.punct1 = punct1;
            this.punct2 = punct2;
        }

        public Punct Punct1 { get => punct1; set => punct1 = value; }
        public Punct Punct2 { get => punct2; set => punct2 = value; }

        public override void afisare()
        {
            Console.WriteLine(this);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Linie)) return false;

            Linie linie1 = (Linie)obj;
            return linie1.punct1 == punct1 && linie1.punct2 == punct2;
        }

        public override string ToString()
        {
            return base.Nume;
        }

        public override Figura duplicare()
        {
            MessageBox.Show("S-a duplicat");

            return new Linie(this.punct1, this.punct2, Nume);
        }

        public override void translatare(int x, int y)
        {
            punct1.X += x;
            punct1.Y += y;

            punct2.X += x;
            punct2.Y += y;

//            Console.WriteLine($"S-a translatat\nPunctul1: x={punct1.X}, y={punct1.Y}\n Punctul2: x={punct2.X},y={punct2.Y}");
        }

        public void draw(PictureBox pctDesen, Graphics graphics)
        {

            Pen pen = new Pen(culoare, 1);
            Point point1= new Point(punct1.X,punct1.Y);
            Point point2 = new Point(punct2.X,punct2.Y);
            graphics.DrawLine(pen, point1, point2);
            pctDesen.Refresh();
        }

    }
}
