using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Models
{
    internal class DetaliDesen
    {
        private int id;
        private int idClient;
        private string name;
        private List<int> idFiguri = new List<int>();

        public DetaliDesen(int id,int idClient,string name, List<int> idfiguri)
        {
            this.id = id;
            this.idClient = idClient;
            this.idFiguri = idfiguri;
            this.name = name;
        }

        public DetaliDesen(string text)
        {
            string[] prop = text.Split(';');

            this.id = int.Parse(prop[0]);
            this.idClient = int.Parse(prop[1]);
            this.name = prop[2];
            for (int i = 3; i < prop.Length; i++)
            {
                this.idFiguri.Add(int.Parse(prop[i]));
            }

        }

        public int IdClient { get => idClient; set => idClient = value; }
        public List<int> IdFiguri { get => idFiguri; set => idFiguri = value; }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
