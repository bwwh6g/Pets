using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    public class Pet
    {
        public string type, name, owner;
        public double weight;

        public Pet(string type, string name, string owner, double weight)
        {
            this.type = type;
            this.name = name;
            this.owner = owner;
            this.weight = weight;
        }

        public string getTag()
        {
            return "If lost, call " + owner;
        }
    }
}
