using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPolimorfismul.Models
{
    public class Eticheta:Dreptunghi
    {

        string text;

        public Eticheta(string text, Punct punct1, Punct punct2):base(punct1, punct2)
        {
            this.text = text;
        }

        public string Text { get => text; set => text = value; }

        public override void afisare()
        {
            Console.WriteLine($"Avem un dreptunghi cu un text in el cu coordonatele x={Punct1.X},y={Punct1.Y} si x1={Punct2.X},y1={Punct2.Y}");
        }

        public override Figura duplicare()
        {
            Console.WriteLine("S-a duplicat");
            return this;
        }

        public override void translatare(int x, int y)
        {
            base.translatare(x, y);
            Console.WriteLine("S-a mutat");
        }
    }
}
