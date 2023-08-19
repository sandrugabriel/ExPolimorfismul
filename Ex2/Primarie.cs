using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Primarie : Cladire
    {

        private int x;
        private int y;
        private string strada;

        public Primarie(int x, int y, string strada)
        {
            this.x = x;
            this.y = y;
            this.strada = strada;
        }

        public override string ToString()
        {
            return $"Primaria se afla pe str. {strada} la x={x}, y={y}";
        }

        public override void afisare()
        {
            Console.WriteLine(this);
        }

        public override Cladire duplicare()
        {
            return new Primarie(x, y, strada);
        }

        public override void translatare(int x, int y)
        {
           this.y += y;
            this.x += x;
            Console.WriteLine($"Primaria s-a mutat la x={this.x},y={this.y}");
        }


    }
}
