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
    class Flight
    {
        //Private Instance variables++++++++++++++++++++
        private bool[] _seatsAvailible = new bool[10];
        private string ChangeClass;

        //Public Properties ++++++++++++++++++++++++++++
        public Flight()
        {
            _initializeArray();
        }


        //Private Methdos ++++++++++++++++++++++++++++++
        private void _initializeArray()
        {
            for (int i = 0; i < _seatsAvailible.Length; i++)
            {
                this._seatsAvailible[i] = false;
            }
        }

        //Public Methods +++++++++++++++++++++++++++++++
        public void FirstClass()
        {
            int seatNumber = 0;
            while (seatNumber < 5)
            {
                if (_seatsAvailible[seatNumber] == false)
                {
                    this._seatsAvailible[seatNumber] = true;
                    this.viewSeats();
                    break;

                }
                else if (seatNumber == 4)
                {
                    Console.WriteLine("All first class seats have been booked");
                    Console.WriteLine("Whould you like to book your seat in the Economic Class?/n Y) Yes /n N) No");
                    ChangeClass = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Next flight leaves in 3 hours");
                }
                if (ChangeClass == "Y")
                {
                    EconomicClass();
                }
                else
                {

                }
                seatNumber++;
            }
        }

        public void EconomicClass()
        {
            int seatNumber = 5;
            while (seatNumber < 10)
            {
                if (_seatsAvailible[seatNumber] == false)
                {
                    this._seatsAvailible[seatNumber] = true;
                    this.printEconomicclass();
                    break;
                }
                else if (seatNumber == 9)
                {
                    Console.WriteLine("All Economic class Seats have been booked.");
                    Console.WriteLine("Would you like to book your seat in First Class? Y) Yes  N) No");
                    ChangeClass = Convert.ToString(Console.ReadLine());

                }
                if (ChangeClass == "Y")

                    FirstClass();
                else
                {

                }

            }
            seatNumber++;
        }
        public void viewSeats()
        {
            Console.WriteLine();
            for (int index = 0; index < _seatsAvailible.Length; index++)
            {
                if (this._seatsAvailible[index] == true)
                {
                    Console.WriteLine("First Class Seat Booked");
                }

                else if (index > 5)
                {
                    Console.WriteLine("Economic Class Seat Booked");
                }
            }
            Console.WriteLine();
        }
        public void printEconomicclass()
        {
            for (int index = 6; index < _seatsAvailible.Length; index++)
            {
                if (this._seatsAvailible[index] == true)
                {
                    Console.Write(" Economic Class Seat Selected  ");
                }

            }
        }
        public void Exit()
        {
            Console.Clear();
        }

    }
}
