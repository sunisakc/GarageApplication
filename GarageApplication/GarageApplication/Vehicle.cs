using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{
    class Vehicle
    {
        private int registerNumber;
        private string color;
        private int numberOfWheel;


        public int RegistNumber
        {
            get
            {
                return registerNumber;
            }
            set
            {
                registerNumber = value;
            }
        }
        public string Color {
            get
            {
                return color;
            }
             set
             {
                    color = value;
             }
            }
        public int NumberofWheel {
             get
            {
                return numberOfWheel;
            }
              set
            {
                numberOfWheel = value;
            }
                
              }

        public Vehicle () { }

        public Vehicle( int registerNumber, string color, int numberofWheel)
        {
            RegistNumber = registerNumber;
            Color = color;
            NumberofWheel = numberofWheel;
        }

        public virtual string PrintVehicle()
        {
            return "Regnr: " + RegistNumber + "\n" +
                "Color: " + Color + "\n" + "Nr of wheels: " + NumberofWheel + ".";
        }

    }
}
