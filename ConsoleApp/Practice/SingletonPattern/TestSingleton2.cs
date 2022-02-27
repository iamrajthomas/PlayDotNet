using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Practice.SingletonPattern
{
    class TestSingleton2
    {
        static void Main()
        {
            Console.WriteLine("Singleton with 2nd base variant [multi threaded model]: ============================================================");

            Parallel.Invoke(
                () => PrintEmployeeDetail(),
                () => PrintStudentDetail(),
                () => PrintTeacherDetail()
            );

            Console.WriteLine("============================================================");

            Console.ReadLine();
        }

        private static void PrintTeacherDetail()
        {
            Singleton2 fromTeacher = Singleton2.GetInstance;
            fromTeacher.PrintSomething("Hello fromTeacher");
        }

        private static void PrintStudentDetail()
        {
            Singleton2 fromStudent = Singleton2.GetInstance;
            fromStudent.PrintSomething("Hello fromStudent");
        }

        private static void PrintEmployeeDetail()
        {
            Singleton2 fromEmployee = Singleton2.GetInstance;
            fromEmployee.PrintSomething("Hello fromEmployee");
        }
    }
}
