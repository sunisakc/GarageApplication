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


        private int capacity;
        private int count;
        //private bool[] isAvailable;
        private List<T> listVehicle;



        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public int Count
        {
            get { return listVehicle.Count(); }
            
        }
        //public bool IsAvailable
        //{
        //    get { return isAvailable; }
        //    set { isAvailable = value; }
        //}

        public Garage(int maxCapSize)
        {
            listVehicle = new List<T>();
            capacity = maxCapSize;
            Console.WriteLine("Your garage size is:" + maxCapSize);
        }
 



        public void Park(T input)
        {
            if (capacity - listVehicle.Count <= 0)
            {
                Console.WriteLine("**********");
                return;
            }

            if (count < capacity)
            {
                listVehicle.Add(input);
                foreach (var i in listVehicle)
                {
                    Console.WriteLine("Parked slot :" + listVehicle.IndexOf(i) + "");
                }
            }
            //Console.WriteLine("You create: " + (capacity - listVehicle.Count));
            //Console.ReadLine();
        }
        public void Unpark(T input)
        {
            if(count < capacity)
            {
                listVehicle.Remove(input);
                foreach( var i in listVehicle.Where(x => x.RegNumber.StartsWith(x.RegNumber)))
                {
                    Console.WriteLine("Your vehicle is unparked and Thank you for parking");
                }
                Console.WriteLine("Your garage is " + Count);
                Console.ReadLine();
            }

        }
        public void ListofVehicle()
        {
            if (listVehicle.Count == 0)
            {
                Console.WriteLine("Garage is empty");
            }
            else
            {
                foreach (var vehicle in listVehicle)
                    Console.WriteLine(vehicle);
            }
            Console.ReadLine();
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                { yield return listVehicle[i]; }
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)listVehicle).GetEnumerator();
        }




    }
}