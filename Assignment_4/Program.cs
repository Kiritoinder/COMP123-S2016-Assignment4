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

        }
    }
}
