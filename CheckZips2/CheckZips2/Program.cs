using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CheckZips2
{
    class Program
    {
        static void Main(string[] args)
        {
            int userZip;
            WriteLine("Enter your 5 digit zip code to see if we deliver to your area >> ");
            userZip = Convert.ToInt32(ReadLine());
            displayZipCode(userZip);
        }
        static void displayZipCode(int zip)
        {
            int[] zips = { 51111, 66666, 99999, 87423, 55555,
                33333, 88887, 74123, 44444, 85633 };
            int result = 0;

            for (int i = 0; i <= 10; i++)
            {
                if (zips[i] == zip)
                {
                    WriteLine("We can deliver!");
                    result = 1; 
                }
            }
            if (result != 1)
            {
                WriteLine("We do not deliver to your area");
            }
        }
    }
}

