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

    }
}
