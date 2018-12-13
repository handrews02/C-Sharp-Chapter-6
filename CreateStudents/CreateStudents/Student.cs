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
            Write("Enter students last name >>>> ");
            second.lastName = ReadLine();
            Write("Enter students Id number >>> ");
            second.IdNumber = ReadLine();
            Write("Enter students GPA >>> ");
            second.GradePointAverage = ReadLine();

            Display(first);
            Display(second);

        }
        static void Display(Student stu)
        {
            WriteLine("{0} {1} {2} ", stu.IdNumber, stu.LastName, stu.GradePointAverage);
        
        }
    }
}
