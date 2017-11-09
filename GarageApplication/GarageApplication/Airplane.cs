using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{
    class Airplane : Verhicle
    {
        private int numberofEngines;
        private int length;


        public int NumberOfEngines
        {
            get { return numberofEngines; }
            set { numberofEngines = value; }
            
        }

        public int Lenght
        {
            get { return length; }
            set { length = value; }

        }

        public Airplane ():base() { }

        public Airplane(int registerNumber, string color, int numberofWheel, int numberofEngine, int lenght):
            base(registerNumber, color, numberofWheel)
        {
            NumberOfEngines = numberofEngines;
            Lenght = lenght;
        }

        
    }
}
