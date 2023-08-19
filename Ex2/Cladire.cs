using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Cladire
    {

        public virtual void afisare()
        {
            Console.WriteLine("Cladire");
        }

        public virtual Cladire duplicare() {

            return null;
        }

        public virtual void translatare(int x, int y)
        {

            Console.WriteLine($"S-a mutat la x={x},y={y}");

        }


    }
}
