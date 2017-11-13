using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication.GarageCreator
{
    class GarageOne : Vehicle
    {
        internal void GetSize(Vehicle newvehicle)
        {
            int nr = 1;

            Garage<Vehicle> grcreator = new Garage<Vehicle>(nr);

            foreach (var i in grcreator)
            {
                return;
            }
            Console.ReadLine();
        }
    }

}