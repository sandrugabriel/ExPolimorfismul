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
        private int raza;
        private Punct punct;

        public int Raza { get => raza; set => raza = value; }
        public Punct Punct { get => punct; set => punct = value; }

        public Cerc(string type,int id,int raza, Punct punct, string name):base(name, id, type)
        {

            this.raza = raza;
            this.punct = punct;

        }

        public Cerc(string text) : base(text)
        {

            string[] prop = text.Split(';');

            this.raza = int.Parse(prop[3]);
            this.punct = new Punct(int.Parse(prop[4]),int.Parse(prop[5]));

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

            return new Cerc(Type,Id,this.raza, this.punct,Nume);
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
