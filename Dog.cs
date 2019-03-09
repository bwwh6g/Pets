using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    public class Dog : Pet
    {
        public Dog(string name, string owner, double weight) : base(type, name, owner, weight)
        {
            type = "dog";
            this.name = name;
            this.owner = owner;
            this.weight = weight;

        }

        public string bark(int count)
        {
            string str;
            for (int i = 0; i < count; i++)
            {
                str += ("bark!");
            }
            return str;
        }


    }
}
