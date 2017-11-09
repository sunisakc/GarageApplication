using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{
    class Car : Verhicle
    {
        private int numberOfSeats;


        public int NumberOfSeats { get; set; }

        public Car() : base() { }

        
        public Car(int registerNumber, string color, int numberofWheel, int numberOfSeats):
                  base(registerNumber, color, numberofWheel)

        {
            NumberOfSeats = numberOfSeats;
        }

    }

    
}
