using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{
    class Boat : Verhicle
    {

        private int height;



        public int Height
        {
            get { return height; }
            set { height = value; }

        }

        public Boat(): base() { }

        public Boat(int registerNumber, string color, int numberofWheel, int numberOfSeats,  int height) :
            base(registerNumber, color, numberofWheel)
        {
           
            Height = height;
        }
    }
}
