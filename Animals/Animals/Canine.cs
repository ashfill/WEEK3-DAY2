using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Canine : Mammal
    {
        public Canine()
        {
            NumLegs = 4;
            HasFur = true;
            Species = "Canis";
            HasTail = true;
            HasOpposableThumb = false;
        }

        public string BreedName { get; set; }
        public Human Owner { get; set; }
        public string DogName { get; set; }

        public void Adopted(Human adoptee)
        {
            Owner = adoptee;
        }

        public void Adopted(Human adoptee, string newName)
        {
            Owner = adoptee;
            DogName = newName;
        }
    }
}
