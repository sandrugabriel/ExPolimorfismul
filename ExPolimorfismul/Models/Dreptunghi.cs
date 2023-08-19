using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPolimorfismul.Models
{
    public class Dreptunghi : Figura
    {

        Punct punct1;
        Punct punct2;

        public Dreptunghi(Punct punct1, Punct punct2)
        {
            this.punct1 = punct1;
            this.punct2 = punct2;
        }

        public Punct Punct1 { get => punct1; set => punct1 = value; }
        public Punct Punct2 { get => punct2; set => punct2 = value; }

        public override void afisare()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return "Dreptunghi:\n" + punct1 + "\n" + punct2;
        }

        public override Figura duplicare()
        {
            Console.WriteLine("S-a duplicat");

            return new Dreptunghi(this.punct1,this.punct2);
        }

        public override void translatare(int x, int y)
        {

            punct1.X += x;
            punct1.Y += y;
            punct2.X += x;
            punct2.Y += y;

            Console.WriteLine("S-a mutat dreptunghiul");

        }
    }
}
