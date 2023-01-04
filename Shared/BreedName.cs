using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAboutDogs.Shared
{
    public class BreedName
    {
        public string Name { get; set; }

        public BreedName(string n )
        {   
            this.Name = n;
        }
        public BreedName() {
            Name = "";
                }


    }
}
