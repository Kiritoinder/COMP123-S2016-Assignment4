using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Author: Inderjeet Singh
 * StudentNumber: 300874118
 * Description: Driver class for Dice Rolling Simulation
 * Version: 0.0.1
 * DateCreated: July 21rd, 2016
 * DateModified: July 21rd, 2016
 */
namespace Assignment_4
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
            int[] tally = new int[13];

            Random random = new Random();

            int presentNumber = 0;

            // This loop calculates the sum of two numbers on dice
            for (int rolls = 1; rolls < 36000; rolls++)
            {
                presentNumber = random.Next(1, 7) + random.Next(1, 7);

                ++tally[presentNumber];
            }
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("************************************");
            Console.WriteLine("Dice #   |    Number of times rolled");
            //This loop outputs the sum of the two # and the number of
            // times the sum is repeated
            for (int Index = 2; Index < 13; ++Index)
            {
                Console.WriteLine("{0,4}     | {1,17}", Index, tally[Index]);
            }
            Console.WriteLine("*************************************");
            Console.ReadLine();
        }
    } // End of namespace
}// End of program
