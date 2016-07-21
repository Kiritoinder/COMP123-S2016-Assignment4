using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Reservation_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection = 0;
            Random random = new Random();
            Flight lufthansa = new Flight();
            while (selection != 3)
            {
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
    }
}
