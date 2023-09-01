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

    }
}
