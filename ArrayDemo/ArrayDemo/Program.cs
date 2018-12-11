using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] entries;
            entries = new int[8];
            int i = 0;
            int location;
            int guess = 0;


            for(i = 0; i < 8; i++) {
                Write("Enter a number " + i + " >> ");
                entries[i] = Convert.ToInt32(ReadLine());   
            }
            while(guess != 999)
            {
                WriteLine("enter '1' to see them in order. enter '2' to see them in reverse order. enter '3' to display a specific location.");
                guess = Convert.ToInt32(ReadLine());

                if (guess == 1)
                {

                    for (int j = 0; j < entries.Length; j++)
                    {
                        WriteLine("Numbers entered in order were " + entries[j]);
                    }
                }
                else if (guess == 2)
                {

                    Array.Reverse(entries);
                    for (int z = 0; z < entries.Length; z++)
                    {
                        WriteLine("Numbers in reverser order were " + entries[z]);
                    }
                }
                else if(guess == 3)
                {
                    WriteLine("Enter a location >> ");
                    location = Convert.ToInt32(ReadLine());

                    WriteLine(entries[location - 1]);
                }
            }
       

        }
    }
}
