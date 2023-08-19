using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Magazin :Cladire
    {

        private int x;
        private int y;
        private string name;

        public Magazin(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public override string ToString()
        {
            return $"Magazinul {name} se afla la x={this.x}, y={this.y}";
        }

        public override void afisare()
        {
            Console.WriteLine(this);
        }

        public override Cladire duplicare()
        {
            return new Magazin(x, y, name);
        }

        public override void translatare(int x, int y)
        {
           this.x += x;
            this.y += y;
            Console.WriteLine($"Magazinul s-a mutat la x={this.x}, y={this.y}");
        }

    }
}
