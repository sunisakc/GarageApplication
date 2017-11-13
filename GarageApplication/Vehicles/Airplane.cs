using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication.Vehicles
{
    class Airplane : Vehicle
    {
        private int numberofEngines;
        


        public int NumberOfEngines
        {
            get { return numberofEngines; }
            set { numberofEngines = value; }

        }

      

        public Airplane() : base() { }

        public Airplane(string regNumber, string color, int numberofWheel, int numberofEngine) :
            base(regNumber, color, numberofWheel)
        {
            NumberOfEngines = numberofEngines;
            
        }


    }
}