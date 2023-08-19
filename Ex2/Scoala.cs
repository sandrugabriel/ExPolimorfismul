using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Scoala :Cladire
    {

        private string name;
        private int x;
        private int y;

        public Scoala(string name, int x, int y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"Scoala {name} se afla la x={x},y={y}";
        }

        public override void afisare()
        {
            Console.WriteLine(this);
        }

        public override Cladire duplicare()
        {
            return new Scoala(name, x, y);
        }

        public override void translatare(int x, int y)
        {
            this.x += x;
            this.y += y;
            Console.WriteLine($"Scoala s-a mutat la x={x},y={y}");
        }
    }
}
