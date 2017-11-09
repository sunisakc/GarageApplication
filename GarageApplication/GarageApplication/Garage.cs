using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{
    class Garage<T> : IEnumerable<T> where T : Verhicle
    {
        //private int regNr;
        //private int name;
        //private int capacity;
        //private int count;
        //private bool isAvailable;
        //private T[] listArray;



        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
