using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{
    class Boat : Verhicle
    {
        private string typeOfBoat;
        private int height;

        public string TypeOfBoat { get; set; }
        public int Height { get; set; }
        
        public Boat(): base() { }

        public Boat(int registerNumber, string color, int numberofWheel, int numberOfSeats, string typeOfBoat, int height) :
            base(registerNumber, color, numberofWheel)
        {

        }
    }
}
