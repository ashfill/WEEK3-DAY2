using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Mammal : Animal
    {
        public Mammal()
        {
            GivesLiveBirth = true;
            NumChildren = 0;
        }

        public override int NumLegs { get; set; }
        public override bool HasFur { get; set; }
        public override bool GivesLiveBirth { get; }

        public string Species { get; set; }
        public bool HasTail { get; set; }
        public bool HasOpposableThumb { get; set; }
        public bool HasOffspring { get; set; }
        public int NumChildren { get; set; }

        public void GiveBirth()
        {
            HasOffspring = true;
            NumChildren++;
        }

        public void GiveBirth(int numBabies)
        {
            HasOffspring = true;
            NumChildren += numBabies;
        }
    }
}
