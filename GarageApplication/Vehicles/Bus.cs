using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication.Vehicles
{
     class Bus : Vehicle
    {

        private int weight;


        public int Weight
        {
            get { return weight; }
            set { weight = value; }

        }

        public Bus() : base() { }


        public Bus(string regNumber, string color, string numberofWheel, int weight) :
                  base(regNumber, color, numberofWheel)

        {
            Weight = weight;
        }

    }
}