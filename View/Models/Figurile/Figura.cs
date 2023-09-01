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
        private string type;
        private int id;
        private string nume;

        public Color culoare { get; set; }

        public virtual void draw(PictureBox pictureBox, Graphics graphics)
        {

        }

        public string Nume { get => nume; set => nume = value; }

        public int Id { get => id; set => id = value; }

        public string Type { get => type; set => type = value; }

        public Figura(string nume,int id, string type) {
        
            this.nume = nume;
            this.id = id;
            this.type = type;
        }

        public Figura(string text)
        {
            string[] prop = text.Split(';');

            this.type = prop[0];
            this.id = int.Parse(prop[1]);
            this.nume = prop[2];
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
