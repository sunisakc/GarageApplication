using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication.Vehicles
{
    class Boat :Vehicle
    {

        private int height;



        public int Height
        {
            get { return height; }
            set { height = value; }

        }

        public Boat() : base() { }

        public Boat(string regNumber, string color, int numberofWheel, int numberOfSeats, int height) :
            base(regNumber, color, numberofWheel)
        {

            Height = height;
        }
    }
}