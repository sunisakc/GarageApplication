using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication.Vehicles
{
    class Car : Vehicle
    {
        private int numberOfSeats;


        public int NumberOfSeats
        {
            get { return numberOfSeats; }
            set { numberOfSeats = value; }

        }
        public Car() : base() { }


        public Car(string regNumber, string color, string numberofWheel, int numberOfSeats) :
                  base(regNumber, color, numberofWheel)

        {
            NumberOfSeats = numberOfSeats;
        }

    }


}