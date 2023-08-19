using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPolimorfismul.Models
{
    public class Figura
    {
        public virtual void afisare()
        {
            Console.WriteLine( "afisare");
        }

        public virtual void translatare(int x,int y)
        {
            Console.WriteLine($" translateare pe x={x}, y={y}");
        }

        public virtual Figura duplicare()
        {
            Console.WriteLine("duplicare");
            return null;
        }
    }
}
