using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Casa : Cladire
    {

        private int x;
        private int y;

        public Casa(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override void afisare()
        {
            Console.WriteLine(this);
        }

        public override Cladire duplicare()
        {
            return new Casa(x,y);
        }

        public override void translatare(int x, int y)
        {
            this.x += x;
            this.y += y;
            Console.WriteLine($"Casa s-a mutat la x={this.x},y={this.y}");
        }

        public override string ToString()
        {
            return $"Casa este la x={x},y={y}";
        }
    }
}
