using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAboutDogs.Shared
{
    public class Dog
    {
        public int id { get; set; }

        public string breedName { get; set; }

        public string bredFor { get; set; }

        public string breedGroup { get; set; }

        public string temperment { get; set; }

        public string origin { get; set; }
        
        public string imageURL { get; set; }

        public decimal MaxWeight { get; set; }
        public decimal MinWeight { get; set; }
        public decimal MaxHeight { get; set; }  
        public decimal MinHeight { get; set; }
        public decimal MinLife { get; set; }
        public decimal MaxLife { get; set; }

        public Dog(int id, string breedName, string bredFor, string breedGroup ,string tempermant, string origin, string imageURL, decimal maxWeight, decimal minWeight, decimal maxHeight, decimal minHeight, decimal maxLife, decimal minLife) {
            this.id = id;
            this.breedName = breedName;
            this.bredFor = bredFor;
            this.breedGroup = breedGroup;
            this.temperment = tempermant;
            this.origin = origin;
            this.imageURL = imageURL;
            this.MinWeight = minWeight;
            this.MaxWeight = maxWeight;
            this.MinHeight = minHeight;
            this.MaxHeight = maxHeight;
            this.MinLife = minLife;
            this.MaxLife = maxLife;
            
        }
        
        public Dog() { }
    }
}
