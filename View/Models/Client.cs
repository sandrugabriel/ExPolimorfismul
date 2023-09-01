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

        public Client(int id, string name,string pass) {
        
            this.name = name;
            this.id = id;
            this.password = pass;
        
        }

        public Client(string text)
        {
            string[] prop = text.Split(';');

            this.id = int.Parse(prop[0]);
            this.name = prop[1];
            this.password = prop[2];

        }

        public int Id { get => id; set => id = value; }

        public string Name { get => name; set => name = value; }

        public string Password { get => password; set => password = value; }

    }
}
