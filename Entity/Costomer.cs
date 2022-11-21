using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Costomer
    {
        int id; string name, phone, adress;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Adress { get => adress; set => adress = value; }

        public Costomer(int id, string name, string phone, string adress)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.adress = adress;
        }

        public Costomer(string name, string phone, string adress)
        {
            this.name = name;
            this.phone = phone;
            this.adress = adress;
        }
    }
}
