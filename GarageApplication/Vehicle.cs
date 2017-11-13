using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{
    class Vehicle
    {
        private string name;
        private string regNumber;
        private string color;
        private int numberOfWheel;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string RegNumber
        {
            get
            {
                return regNumber;
            }
            set
            {
                regNumber = value;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public int NumberofWheel
        {
            get
            {
                return numberOfWheel;
            }
            set
            {
                numberOfWheel = value;
            }

        }

        

        public Vehicle() { }

        public Vehicle(string regNumber, string color, int numberofWheel)
        {
            RegNumber = regNumber;
            Color = color;
            NumberofWheel = numberofWheel;
        }

       

        public override string ToString()
        {
            return 
                "\nVehicle register number is:" + regNumber +
            "\nVehicle color is:" + Color +
            "\nVehicle has " + numberOfWheel + "number of wheel";
        }
        
        
    }
    
}
