using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace UseCalcPay
{
    class Program
    {
        static void Main(string[] args)
        {
            double myHours = 37.5;
            double myRate = 12.75;
            double grossPay;

            grossPay = CalcPay(myHours, myRate);
            WriteLine("I worked {0} hours at ${1} per hour",myHours, myRate);
            WriteLine("My gross pay is ${0}", grossPay.ToString("C"));
        }
        private static double CalcPay(double hours, double rate)
        {
            double gross;
            gross = hours * rate;
            return gross;
        }
    }
}
