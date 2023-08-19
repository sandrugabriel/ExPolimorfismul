using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPolimorfismul.Models
{
    internal class Desen:Figura
    {

        private List<Figura> figuri;

        public Desen(List<Figura> list)
        {

            figuri = list;

        }

        public override void afisare()
        {
            for(int i=0;i<figuri.Count;i++)
            {
                figuri[i].afisare();
            }
        }

        public override Figura duplicare()
        {
           return figuri[figuri.Count-1];
        }

        public override void translatare(int x, int y)
        {
           for(int i=0;i< figuri.Count;i++)
            {
                figuri[i].translatare(x, y);
            }
        }

        public void descriereDesen()
        {
            
            for(int i=0;i<figuri.Count; i++)
            {

               figuri[i].afisare();
                Console.WriteLine("\n");
            }

        }


    }
}
