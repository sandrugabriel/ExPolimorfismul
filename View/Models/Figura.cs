using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Models
{
    internal class Figura
    {

        private string nume;

        public Color culoare { get; set; }

        public virtual void draw(PictureBox pictureBox, Graphics graphics)
        {

        }

        public string Nume { get => nume; set => nume = value; }

        public Figura(string nume) {
        
            this.nume = nume;
        }

        public virtual void afisare()
        {
            Console.WriteLine("afisare");
        }

        public virtual void translatare(int x, int y)
        {
          //  Console.WriteLine($" translateare pe x={x}, y={y}");
        }

        public virtual Figura duplicare()
        {
           // Console.WriteLine("duplicare");
            return null;
        }
    }
}
