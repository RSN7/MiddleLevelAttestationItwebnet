using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App11
{
    public class House
    {

        public Owner Owner { get; set; }
        public string Address { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public object DeepClone() 
        {
            Owner owner = new Owner
            {
                Name = this.Owner.Name,
                Surname = this.Owner.Surname,
                Age = this.Owner.Age
            };

            return new House
            {
                Owner = owner,
                Address = this.Address
            };
        }
    }
}
