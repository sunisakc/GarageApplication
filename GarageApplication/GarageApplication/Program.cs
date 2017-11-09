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
          

            Console.WriteLine("Welcome to our magic garage");

            int[] userInput = new int[21];
            int counter = 0;

            for (counter = 0; counter < userInput.Length; counter++)
            {
                string input = Console.ReadLine();

                if (input == "")
                    break;
                else
                    int.TryParse(input, out userInput[counter]);
            }
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine(userInput[i]);
            }
            Console.ReadLine();
           


            }

    }
    }

    