using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPolimorfismul.Models
{
    public class Punct:Figura
    {
        private int x;
        private int y;

        public Punct(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public override void afisare()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"Punct:\nx={x}, y={y}";
        }

        public override Figura duplicare()
        {

            return new Punct(this.x,this.y);
        }

        public override void translatare(int x1, int y1)
        {
            x += x1;
            y += y1;
        }

        public override bool Equals(object? obj)
        {

            if (obj == null || !(obj is Punct))
            {
                return false;
            }

            Punct p1 = (Punct)obj;
            return p1.x == x && p1.y == y;
        }
    }
}
