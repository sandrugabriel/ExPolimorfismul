using Microsoft.VisualBasic.ApplicationServices;
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
    internal class ControllerClient
    {

        List<Client> clienti;

        public ControllerClient()
        {
            clienti = new List<Client>();

            load();
        }

        public void load() {

            string path = Application.StartupPath + @"/data/useri.txt";

            StreamReader streamReader = new StreamReader(path);

            string t = "";

            while((t = streamReader.ReadLine()) != null)
            {
                clienti.Add(new Client(t));
            }

            streamReader.Close();
        }

        public void afisare()
        {
            foreach (Client client in clienti)
            {
                MessageBox.Show(client.Id.ToString());
            }
        }

        public bool verificare(string name, string pass)
        {

            for(int i = 0; i < clienti.Count; i++)
            {
                if (clienti[i].Name == name && clienti[i].Password == pass)
                {
                    return true;
                }
            }
            return false;
        }

        public Client getClient(string name, string pass)
        {

            for (int i = 0; i < clienti.Count; i++)
            {
                if (clienti[i].Name == name && clienti[i].Password == pass)
                {
                    return clienti[i];
                }
            }
            return null;
        }

        public Client getById(int id)
        {

            for (int i = 0; i < clienti.Count; i++)
            {
                if (id == clienti[i].Id) return clienti[i];
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

        public void save(string text)
        {

            string path = Application.StartupPath + @"/data/useri.txt";
            File.AppendAllText(path, text + "\n");

        }

        public int pozIdClient(int id)
        {

            for(int i = 0; i < clienti.Count; i++)
            {
                if (clienti[i].Id == id) return i;
            }
            return -1;
        }

        public bool validFav(int idDesen, int idClient)
        {
            
           // List<int> like = clienti[pozIdClient(idClient)].Like;
            List<int> fav = clienti[pozIdClient(idClient)].Favorite;

            for(int i=0;i<fav.Count;i++)
                if (fav[i] == idDesen) return true;
            return false;
        }

        public bool validLike(int idDesen, int idClient)
        {

             List<int> like = clienti[pozIdClient(idClient)].Like;
            //List<int> fav = clienti[pozIdClient(idClient)].Favorite;

            for (int i = 0; i < like.Count; i++)
                if (like[i] == idDesen) return true;
            return false;
        }
    }
}
