using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{
    class Motorcycle : Verhicle
    {
        private int cylindervolume;

        public int CylinderVolume
        {
            get { return cylindervolume; }
            set { cylindervolume = value; }

        }

        public Motorcycle(): base() { }

        public Motorcycle(int registerNumber, string color, int numberofWheel, int cylindervolume):
           base(registerNumber, color, numberofWheel)
        {

           CylinderVolume = cylindervolume;
        }

    }
}
