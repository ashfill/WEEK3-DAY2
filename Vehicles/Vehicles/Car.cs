using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(string make, int numDoors) : base(make)
        {
            for(int i = 0; i < _tires.Length; i++)
            {
                Tire newTire = new Tire();
                _tires[i] = newTire;
            }

            _numDoors = numDoors;

            ChangeOil();
        }

        #region Member Variables

        Tire[] _tires = new Tire[4];
        int _numDoors;

        #endregion

        #region Properties

        public int NumDoors
        {
            get
            {
                return _numDoors;
            }
        }

        public int Miles
        {
            get { return base.Milage; }
        }

        public int OilChangeMilage
        {
            get { return base.MilageOfNextOilChange; }
        }

        public Tire[] Tires
        {
            get { return _tires; }
        }

        #endregion

        #region Methods

        public override void ChangeOil()
        {
            MilageOfNextOilChange = Milage + 3000;
        }

        public override void AddMilage(int miles)
        {
            Milage += miles;

            for(int i = 0; i < _tires.Length; i++)
            {
                _tires[i].AddMiles(miles);
            }
        }

        public override void ChangeTire(int whichTire)
        {
            if (whichTire <= _tires.Length && whichTire > 0)
            {
                _tires[whichTire - 1] = new Tire();
            }
        }

        public override bool OilChangeNeeded()
        {
            if (Milage >= MilageOfNextOilChange)
                return true;
            else
                return false;
        }

        public void ChangeAllTires()
        {
            for (int i = 0; i < _tires.Length; i++)
            {
                _tires[i] = new Tire();
            }
        }

        #endregion
    }
}
