using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{
    class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        //private int regNr;
        //private int name;
        //private int capacity;
        //private int count;
        //private bool isAvailable;
        //private T[] listArray;

        private T[] vehicleArray;
        private int capacity;
        private int count;

        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }

        public int Count
        {
            get
            {
                return capacity;
            }
            private set
            {
                count = value;
            }
        }

        public Garage(int cap)
        {
            Capacity = cap;
            vehicleArray = new T[capacity];
        }

        public void Park(T input)
        {
            if (count < capacity)
            {
                vehicleArray[count++] = input;
            }
        }

        public void Unpark(T input)
        {
            if (count < capacity)
            {
                vehicleArray[count--] = input;
            }
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return vehicleArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
