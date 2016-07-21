using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Author: Inderjeet Singh
 * StudentNumber: 300874118
 * Description: Driver class for Airline_Reservation_System
 * Version: 0.0.1
 * DateCreated: July 21rd, 2016
 * DateModified: July 21rd, 2016
 */
namespace Airline_Reservation_System
{
 /**
 * this class is the "driver" class for my program
 * @class Program
 */
    class Program
    {
        /**Main method of driver class
         * 
         * @method Main
         * param {string} args
         */
        static void Main(string[] args)
        {
            int selection = 0;
            Random random = new Random();
            Flight lufthansa = new Flight();

            //While loop for making selections from Menu
            while (selection != 3)
            {
                // Menu for booking tickets
                Console.WriteLine("|=====Lufthansa Airline=====");
                Console.WriteLine("|1. For First Class         |");
                Console.WriteLine("|2. For Economy Class       |");
                Console.WriteLine("|3. Exit                    |");
                Console.WriteLine("|===========================| \n");
                Console.Write("Please select from above options: ");
                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                    selection = 0;
                }
                switch (selection)
                {
                    case 1:
                        lufthansa.FirstClass();
                        break;
                        // case 2 does not work properly

                    case 2:
                        lufthansa.EconomicClass();
                        break;
                    case 3:
                        lufthansa.Exit();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input");
                        break;
                }
            }


        }
    }// End of namespace
}// end of program
