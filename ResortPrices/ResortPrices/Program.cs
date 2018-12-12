using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ResortPrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNights;

            WriteLine("Please enter how many nights you will be staying >> ");
            userNights = Convert.ToInt32(ReadLine());

            if(userNights == 1 || userNights == 2)
            {
                WriteLine("It will be $200 per night");
            }
            else if(userNights == 3 || userNights == 4)
            {
                WriteLine("It will be $180 per night");
            }
            else if(userNights == 5 || userNights == 6 || userNights == 7)
            {
                WriteLine("It will be $160 per night");
            }
            else if(userNights >= 8)
            {
                WriteLine("It will be $145 per night");
            }
        }
    }
}
