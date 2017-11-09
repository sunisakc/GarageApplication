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
            //string userInput = Console.ReadLine();

            //int garageSize = int.Parse(userInput);

            //int amountOfGarage = 10;

            //int[] number = new int[amountOfGarage];

            //int positionStartFrom = 0;

            //number[positionStartFrom] = garageSize;
            //Console.WriteLine("Set your size of your garage");
            //int[] garage = new int[12];
            //for(int i = 0; i < garage.Length; i++)
            //{

            //    garage.SetValue(Convert.ToInt32(Console.ReadLine()), i);


            //}

            int[] userInput = new int[20];
            int counter = 0;

            for (counter = 0; counter < userInput.Length; counter++)
            {
                string input = Console.ReadLine();

                if (input == "")
                    break;
                else
                    int.TryParse(input, out userInput[counter]);
            }
            for(int i = 0; i< counter; i++)
            {
                Console.WriteLine(userInput[i]);
            }
            Console.ReadLine();
            }

        }

       
    }

