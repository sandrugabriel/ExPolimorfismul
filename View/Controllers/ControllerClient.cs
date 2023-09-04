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

       // List<int> list;
        public ControllerClient()
        {
            clienti = new List<Client>();
           // list = new List<int>();
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
            //for (int i = 0; i < fav.Count; i++)
                //MessageBox.Show(fav[i].ToString());

                if (fav != null)
            for(int i=0;i<fav.Count;i++)
                if (fav[i] == idDesen) return true;
            return false;
        }

        public bool validLike(int idDesen, int idClient)
        {

             List<int> like = clienti[pozIdClient(idClient)].Like;
            //List<int> fav = clienti[pozIdClient(idClient)].Favorite;
            if(like !=null)
            for (int i = 0; i < like.Count; i++)
                if (like[i] == idDesen) return true;
            return false;
        }

        public void setListfav(int idClient,int idDetalii)
        {
            List<int> list = clienti[pozIdClient(idClient)].Favorite;
            List<int> fav = new List<int>();

            for(int i=0;i< list.Count; i++)
            {
                if (list[i] != idDetalii)
                {
                    fav.Add(list[i]);
                }
            }

            clienti[pozIdClient(idClient)].Favorite = fav;

        }

        public void setListuNFav(int idClient, int idDetali)
        {
            List<int> list = new List<int>();
            if (clienti[pozIdClient(idClient)].Favorite != null)
            {
                for (int i = 0; i < clienti[pozIdClient(idClient)].Favorite.Count; i++)
                    list.Add(clienti[pozIdClient(idClient)].Favorite[i]);
            }
           
            list.Add(idDetali);


            clienti[pozIdClient(idClient)].Favorite = list;

        }

        public void setListuNLike(int idClient, int idDetali)
        {
            List<int> list = new List<int>();

            if (clienti[pozIdClient(idClient)].Like != null)
            {
                for (int i = 0; i < clienti[pozIdClient(idClient)].Like.Count; i++)
                    list.Add(clienti[pozIdClient(idClient)].Like[i]);
            }

            list.Add(idDetali);



            clienti[pozIdClient(idClient)].Like = list;

        }

        public void setListLike(int idClient, int idDetalii)
        {
            List<int> list = clienti[pozIdClient(idClient)].Like;
            List<int> like = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != idDetalii)
                {
                    like.Add(list[i]);
                }
            }

            clienti[pozIdClient(idClient)].Like = like;
        }

        public string toSave()
        {
            string t = "";

            for (int i = 0; i < clienti.Count; i++)
            {
                t += clienti[i].tosave() + "\n";
            }

            return t;
        }

        public void update()
        {
            string path = Application.StartupPath + @"/data/useri.txt";
            StreamWriter streamWriter = new StreamWriter(path);

            streamWriter.Write(this.toSave());
            streamWriter.Close();
        }

        public List<int> getIdFav(int id)
        {
            return clienti[pozIdClient(id)].Favorite;
        }

        public List<int> getIdLike(int id)
        {
            return clienti[pozIdClient(id)].Like;
        }
    }
}
