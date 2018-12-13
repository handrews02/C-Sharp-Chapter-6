using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Student
{
    class CreateStudents
    {
        static void Main(string[] args)
        {
            Student first = new Student();
            Student second = new Student();
            first.IdNumber = 123;
            first.lastName = "Burton";
            first.GradePointAverage = 3.5;
        
        }
        static void Display(Student stu)
        {

        }
    }
}
