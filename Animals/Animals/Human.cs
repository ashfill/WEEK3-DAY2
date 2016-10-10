using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Human : Mammal
    {
        public Human()
        {
            NumLegs = 2;
            HasFur = false;
            Species = "Homosapien";
            HasTail = false;
            HasOpposableThumb = true;
            MaritalStatus = 'S';
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char MaritalStatus { get; set; }

        public string GetMarried()
        {
            MaritalStatus = 'M';

            return string.Format("{0}, {1}", LastName, FirstName);
        }

        public string GetMarried(string newFName, string newLName)
        {
            FirstName = newFName;
            LastName = newLName;
            MaritalStatus = 'M';

            return string.Format("{0}, {1}", LastName, FirstName);
        }

        public string GetSingle()
        {
            MaritalStatus = 'S';

            return string.Format("{0}, {1}", LastName, FirstName);
        }

        public string GetSingle(string newFName, string newLName)
        {
            MaritalStatus = 'S';

            return string.Format("{0}, {1}", LastName, FirstName);
        }
    }
}
