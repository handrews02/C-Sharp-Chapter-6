using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TemperatureList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] temp = new int[7];
            int i;
            int average = 0;
            double difference;

            for (i = 0; i < 7; i++)
            {
                Write("Enter the high temperature for the past 7 days >> ");
                temp[i] = Convert.ToInt32(ReadLine());
                average += temp[i];
            }
            average /= 7;
            for (int j = 0; j < temp.Length; j++)
            {
                difference = average - temp[j];
                WriteLine("The temps you entered were {0} and they were {1} from the average {2} ", temp[j], difference, average );
            }
        }
    }
}
