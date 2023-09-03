using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
