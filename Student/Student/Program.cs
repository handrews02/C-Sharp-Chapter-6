using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Student
{
    class Student
    {
        private int idNumber;
        private string lastName;
        private double gradePointAverage;
        private string gender;

        public const double HIGHEST = 4.0;
        public const double LOWEST = 0.0;

        public int IdNumber
        {
            get
            {
                return idNumber;
            }
            set
            {
                idNumber = value;
            }
        }
        public string Lastname
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public double GradePointAverage
        {
            get
            {
                return gradePointAverage;
            }
            set
            {
                if(value >= LOWEST && value <= HIGHEST)
                {
                    gradePointAverage = value;
                }
                else
                {
                    gradePointAverage = LOWEST;
                }
            }
        }

    }
}
