using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication.Vehicles
{
    class Motorcycle : Vehicle
    {
        private int cylindervolume;

        public int CylinderVolume
        {
            get { return cylindervolume; }
            set { cylindervolume = value; }

        }

        public Motorcycle() : base() { }

        public Motorcycle(string regNumber, string color, string numberofWheel, int cylindervolume) :
           base(regNumber, color, numberofWheel)
        {

            CylinderVolume = cylindervolume;
        }

    }
}