using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Models
{
    internal class Client
    {

        private int id;
        private string name;
        private string password;
        private List<int> like = new List<int>();
        private List<int> favorite = new List<int>();

        public Client(int id, string name, string password, List<int> like, List<int> favorite)
        {
            Id = id;
            this.name = name;
            this.password = password;
            this.like = like;
            this.favorite = favorite;
        }

        public Client(string text)
        {
            string[] prop = text.Split(';');

            this.id = int.Parse(prop[0]);
            this.name = prop[1];
            this.password = prop[2];
            int semn = 0;
            if (prop[3] == "fav")
            {
                like = null;
            }else
            for(int i=3;i<prop.Length; i++)
            {

                if (prop[i].Equals("fav"))
                {
                    semn = 1;
                }
                else
                {

                    if (semn == 0)
                    {
                        like.Add(int.Parse(prop[i]));
                    }
                    else
                    {
                        favorite.Add(int.Parse(prop[i]));
                    }

                }


            }

        }

        public int Id { get => id; set => id = value; }

        public string Name { get => name; set => name = value; }

        public string Password { get => password; set => password = value; }
        public List<int> Like { get => like; set => like = value; }
        public List<int> Favorite { get => favorite; set => favorite = value; }

        public string tosave()
        {
            string t = Id.ToString() + ";" + Name.ToString() + ";" + Password.ToString() + ";";
            for (int i = 0; i < like.Count; i++)
            {
                    t += like[i].ToString() + ";";
            }
            t += "fav;";
            MessageBox.Show(favorite.Count.ToString());
            for (int i = 0; i < favorite.Count; i++)
            {
                if (i == favorite.Count - 1)
                    t += favorite[i].ToString();
                else
                    t += favorite[i].ToString() + ";";
            }
            MessageBox.Show(t);
            return t;
        }

    }
}
