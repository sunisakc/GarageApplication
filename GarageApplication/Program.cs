
using GarageApplication.Vehicles;
using GarageApplication.GarageCreator;
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
                Garage<Vehicle> gr = new Garage<Vehicle>(1);


                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to Garage Application");
                    Console.WriteLine("Please navigate through the menu by inputing the number \n(1, 2, 3 ,4, 0) of your choice"
                            + "\n1. Create Garage"
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
                            VehicleList(gr);
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
                Console.WriteLine("How many slots do you need?");                

                string maxSlot = Console.ReadLine();
                int nr;
                while (!int.TryParse(maxSlot, out nr))
                {

                    //for (int i = 1; i <= nr; i++)
                    //{
                    //    Console.WriteLine("You create" + i + "Slot");

                    //}
                    Console.WriteLine("How many slots do you need?");
                    maxSlot = Console.ReadLine();
                }
                Garage<Vehicle> sizeCapacity = new Garage<Vehicle>(nr);

                return sizeCapacity;

            }

        }


            public static void AddVehicle(Garage<Vehicle> gr)
        {
            Console.Clear();
            Console.WriteLine("Please navigate through the menu by inputing the number \n(1, 2, 3 ,4, 0) of your choice"
                            + "\n1. Car"
                            + "\n2. Motorcycle"
                            + "\n3. Bus"
                            + "\n4. Boat"
                            + "\n5. Airplane"
                            + "\n0. Back to main menu");
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
                    AddCar(gr);
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
                case '5':
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
            ////List<Vehicle> listvehicle = new List<Vehicle>();
            //Console.Clear();
            //    Console.WriteLine("Please enter infomation");
            //    string input = " ";
            //    //int nr = int.Parse(Console.ReadLine());
            //    //Garage<Vehicle> grcreator = new Garage<Vehicle>(nr);
            //    Console.WriteLine("What is your vehicle type?");
            //    string vrtype = Console.ReadLine();
            //    Console.WriteLine("What is your register number?");
            //    string regNumber = Console.ReadLine();
            //    Console.WriteLine("How many wheel is your vehicle?");
            //    string numberofWheel = Console.ReadLine();

            ////Console.WriteLine(grcreator.ToString());

            //   Vehicle ve= new Vehicle(regNumber, "red", 4);
            ////Garage<Vehicle> gr = new Garage<Vehicle>(21);
            //gr.Park(ve);
            //gr.ListofVehicle();


            //    Console.ReadLine();


        }


            static void Unpark()
    {
            Console.WriteLine("To unpark your car enter reg.nr:");
            int regist = Int32.Parse(Console.ReadLine());
            Console.WriteLine("You have unparked your vehicle");
            Console.ReadLine();
            }

            static void VehicleList(Garage<Vehicle> gr)
    {
                Console.WriteLine("List of Vehicle");
                gr.ListofVehicle();
                Console.ReadLine();
                
            }

            static void Search()
    {
                Console.WriteLine("Search for parked vehicle");

            }

        static void AddCar(Garage<Vehicle> gr)
        {
            Car car = new Car();
            Console.WriteLine("To park your car we need some information.");
            Console.WriteLine("Enter your registration number: ");
            car.RegNumber = Console.ReadLine();
            Console.WriteLine("Enter your cars color: ");
            car.Color = Console.ReadLine();
            Console.WriteLine("Enter your cars number of wheels:");
            int wheel = Int32.Parse(Console.ReadLine());
            car.NumberofWheel = wheel;
            Console.WriteLine("Enter your cars number of seats:");
            int seats = Int32.Parse(Console.ReadLine());
            car.NumberOfSeats = seats;
            gr.Park(car);
        }



        }
    }
