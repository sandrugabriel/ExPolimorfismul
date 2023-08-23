using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Models
{
    internal class Dreptunghi :Figura
    {

        Punct punct1;
        int width;
        int height;

        public Dreptunghi(Punct punct1, int width, int height, string name):base(name)
        {
            this.punct1 = punct1;
            this.width = width;
            this.height = height;
        }

        public Punct Punct1 { get => punct1; set => punct1 = value; }
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }

        public override void afisare()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return Nume;
        }

        public override Figura duplicare()
        {
            MessageBox.Show("S-a duplicat");

            return new Dreptunghi(this.punct1, this.width,this.height, Nume);
        }

        public override void translatare(int x, int y)
        {

            punct1.X += x;
            punct1.Y += y;

        //    Console.WriteLine("S-a mutat dreptunghiul");

        }

        
        public override void draw(PictureBox pctDesen, Graphics graphics)
        {

            Pen pen = new Pen(culoare, 1);
            graphics.DrawRectangle(pen, punct1.X, punct1.Y, width, height);
            pctDesen.Refresh();
        }

    }
}
