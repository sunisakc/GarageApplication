using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                Garage<Vehicle> gr = new Garage<Vehicle>(21);

                bool run = true;
                while (true)
                {
                    Console.WriteLine("Welcome to Garage Application");
                    Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                            + "\n1. Create Slot"
                            + "\n2. Add Vehicle"
                            + "\n3. Unpark Vehicle"
                            + "\n4. List of Vehicle"
                            + "\n5. Search for Vehicle"
                            + "\n0. Exit the application");
                    char input = ' '; //Creates the character input to be used with the switch-case below.
                    try
                    {
                        input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                    }
                    catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter some input!");
                    }
                    switch (input)
                    {
                        case '1':
                            gr=CreateSlot();
                            break;
                        case '2':
                            AddVehicle(gr);
                            break;
                        case '3':
                            Unpark();
                            break;
                        case '4':
                            VehicleList();
                            break;
                        case '5':
                            Search();
                            break;
                        /*
                         * Extend the menu to include the recursive 
                         * and iterative exercises.
                         */
                        case '0':
                            return;
                        default:
                            Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4, 5)");
                            break;
                    }
                }
            }
        }


       public static Garage<Vehicle> CreateSlot()
        {
            Console.Clear();

            {


                Console.Clear();
                Console.WriteLine("How many slot do you need?");                

                string maxSlot = Console.ReadLine();
                int nr;
                while (!int.TryParse(maxSlot, out nr))
                {

                    //for (int i = 1; i <= nr; i++)
                    //{
                    //    Console.WriteLine("You create" + i + "Slot");

                    //}
                    Console.WriteLine("How many slot do you need?");
                    maxSlot = Console.ReadLine();
                }
                Garage<Vehicle> sizeCapacity = new Garage<Vehicle>(nr);

                return sizeCapacity;

            }

        }


            public static void AddVehicle(Garage<Vehicle> gr)
        {
            //List<Vehicle> listvehicle = new List<Vehicle>();
            Console.Clear();
                Console.WriteLine("Please enter infomation");
                string input = " ";
                //int nr = int.Parse(Console.ReadLine());
                //Garage<Vehicle> grcreator = new Garage<Vehicle>(nr);
                Console.WriteLine("What is your vehicle type?");
                string vrtype = Console.ReadLine();
                Console.WriteLine("What is your register number?");
                string regNumber = Console.ReadLine();
                Console.WriteLine("How many wheel is your vehicle?");
                 string numberofWheel = Console.ReadLine();

            //Console.WriteLine(grcreator.ToString());

               Vehicle ve= new Vehicle(regNumber, "red", numberofWheel);
            //Garage<Vehicle> gr = new Garage<Vehicle>(21);
            gr.Park(ve);
            gr.ListofVehicle();


                Console.ReadLine();


            }


            static void Unpark()
    {

                Console.WriteLine("You have unparked your vehicle");
                Console.ReadLine();
            }

            static void VehicleList()
    {
                Console.WriteLine("List of Vehicle");
                Console.ReadLine();
            }

            static void Search()
    {
                Console.WriteLine("Search for parked vehicle");

            }



        }
    }
