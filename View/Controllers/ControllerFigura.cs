using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Models;

namespace View.Controllers
{
    internal class ControllerFigura
    {

        List<Figura> figuri;

        public ControllerFigura()
        {
            figuri = new List<Figura>();

            load();
        }

        public void load() {

            string path = Application.StartupPath + $@"/data/figuri.txt";
 
            StreamReader streamReader = new StreamReader(path);

            string t = "";

            while((t = streamReader.ReadLine()) != null)
            {
                string type = t.Split(';')[0];

                if (type.Equals("cerc"))
                    figuri.Add(new Cerc(t));

                else if(type.Equals("linie"))
                    figuri.Add(new Linie(t));

                else if(type.Equals("dreptunghi"))
                    figuri.Add(new Dreptunghi(t));

            }

            streamReader.Close();
        }

        public Figura getById(int id)
        {

            for(int i=0;i<figuri.Count;i++)
            {
                if(id == figuri[i].Id) return figuri[i];
            }

            return null;
        }

        public int generareId()
        {

            Random random = new Random();

            int id = random.Next(0,10000);

            while(this.getById(id) != null)
            {
                id = random.Next(0, 100000);
            }

            return id;
        }

        public void save(string text)
        {

            string path = Application.StartupPath + @"/data/figuri.txt";
            File.AppendAllText(path, text+"\n");

        }

    }
}
