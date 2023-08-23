using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Models
{
    internal class Cerc : Figura
    {
        int raza;
        Punct punct;

        public int Raza { get => raza; set => raza = value; }
        public Punct Punct { get => punct; set => punct = value; }

        public Cerc(int raza, Punct punct, string name):base(name)
        {

            this.raza = raza;
            this.punct = punct;

        }

        public override void afisare()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return Nume;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Cerc)) return false;

            Cerc other = (Cerc)obj;
            return other.raza == raza || other.punct == punct;
        }

        public override void translatare(int x, int y)
        {
            punct.X += x;
            punct.Y += y;


         //   Console.WriteLine("Cercul s-a mutat");
        }

        public override Figura duplicare()
        {
            MessageBox.Show("S-a duplicat");

            return new Cerc(this.raza, this.punct,Nume);
        }

        public void draw(PictureBox pctDesen, Graphics graphics)
        {

            // MessageBox.Show(x + "  " + y + "  " + raza);
            Pen pen = new Pen(culoare, 1);
            graphics.DrawEllipse(pen, punct.X - raza, punct.Y - raza, 2 * raza, 2 * raza);
            pctDesen.Refresh();
        }

    }
}
