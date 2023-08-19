using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Desen : Cladire
    {

        private List<Cladire> cladiri;

        public Desen(List<Cladire> cladiri)
        {
            this.cladiri = cladiri;
        }

        public override void afisare()
        {
           for(int i=0;i<cladiri.Count;i++)
            {
                cladiri[i].afisare();
                Console.WriteLine("\n");
            }

        }

        public override Cladire duplicare()
        {
            return cladiri[cladiri.Count-1];
        }

        public override void translatare(int x, int y)
        {
            for(int i=0;i< cladiri.Count;i++)
            {
                cladiri[i].translatare(x,y);
            }
        }

    }
}
