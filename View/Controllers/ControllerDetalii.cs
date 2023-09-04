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
    internal class ControllerDetalii
    {

        List<DetaliDesen> list;
        
        public ControllerDetalii()
        {

            list = new List<DetaliDesen>();

            load();

        }

        public void load()
        {
            string path = Application.StartupPath + @"/data/detali.txt";

            StreamReader streamReader = new StreamReader(path);

            string t = "";

            while((t = streamReader.ReadLine()) != null)
            {
                list.Add(new DetaliDesen(t));
            }

        }

        public void afisare()
        {
            for (int i = 0; i < list.Count; i++)
                MessageBox.Show(list[i].descriere());
        }

        public void save(string text)
        {

            string path = Application.StartupPath + @"/data/detali.txt";
            File.AppendAllText(path, text + "\n");

        }

        public DetaliDesen getById(int id)
        {

            for (int i = 0; i < list.Count; i++)
            {
                if (id == list[i].Id) return list[i];
            }

            return null;
        }

        public int generareId()
        {

            Random random = new Random();

            int id = random.Next(0, 10000);

            while (this.getById(id) != null)
            {
                id = random.Next(0, 100000);
            }

            return id;
        }

        public List<DetaliDesen> getDesene()
        {
            return list;
        }

        public List<DetaliDesen> getFavo(List<int> idDetali)
        {
            List<DetaliDesen> detali = new List<DetaliDesen>();

            for (int i = 0; i < idDetali.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (idDetali[i] == list[j].Id)
                    {
                        detali.Add(list[j]);
                    }
                }
            }

           return detali;
        }

        public List<DetaliDesen> getLike(List<int> idDetali)
        {
            List<DetaliDesen> detali = new List<DetaliDesen>();

            for (int i = 0; i < idDetali.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (idDetali[i] == list[j].Id)
                    {
                        detali.Add(list[j]);
                    }
                }
            }

            return detali;
        }

        public string toSave()
        {
            string t = "";

            for(int i=0;i<list.Count; i++)
            {
                t += list[i].tosave() + "\n";
            }

            return t;
        }

    }
}
