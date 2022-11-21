using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Part
    {
        int id; string name; int cost;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Cost { get => cost; set => cost = value; }

        public Part(int id, string name, int cost)
        {
            this.id = id;
            this.name = name;
            this.cost = cost;
        }

        public Part(string name, int cost)
        {
            this.name = name;
            this.cost = cost;
        }
    }
}
