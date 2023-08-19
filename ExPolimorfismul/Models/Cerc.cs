using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPolimorfismul.Models
{
    public class Cerc :Figura
    {

        Linie raza;
        Punct punct;

        public Linie Raza { get => raza; set => raza = value; }
        public Punct Punct { get => punct; set => punct = value; }

        public Cerc(Linie raza, Punct punct) {
        
            this.raza = raza;
            this.punct = punct;
        
        }

        public override void afisare()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return "Cerc:\nRaza:" + raza.ToString() + "\nPunctul:" +  punct.ToString();
        }

        public override bool Equals(object? obj)
        {
            if(obj == null || !(obj is Cerc)) return false;

            Cerc other = (Cerc)obj;
            return other.raza == raza || other.punct == punct;
        }

        public override void translatare(int x, int y)
        {
            punct.X += x;
            punct.Y += y;

            raza.Punct1.X += x;
            raza.Punct1.Y += y;
            raza.Punct2.X += x;
            raza.Punct2.Y += y;

            Console.WriteLine("Cercul s-a mutat");
        }

        public override Figura duplicare()
        {
            Console.WriteLine("S-a duplicat");

            return new Cerc(this.raza,this.punct);
        }

    }
}
