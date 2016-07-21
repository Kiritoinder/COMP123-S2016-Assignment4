using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tally = new int[13];

            Random random = new Random();

            int presentNumber = 0;

            for (int rolls = 1; rolls < 36000; rolls++)
            {
                presentNumber = random.Next(1, 7) + random.Next(1, 7);

                ++tally[presentNumber];
            }
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("************************************");
            Console.WriteLine("Dice #   |    Number of times rolled");
            //This loop outputs the sum of the two dice and the number of times the sum os got.
            for (int Index = 2; Index < 13; ++Index)
            {
                Console.WriteLine("{0,4}     | {1,17}", Index, tally[Index]);
            }
            Console.WriteLine("*************************************");
            Console.ReadLine();
        }
    }
}
