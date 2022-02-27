using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Practice.SingletonPattern
{
    class TestSingleton4
    {
        static void Main()
        {
            Console.WriteLine("Singleton with multi threaded model with Lazy Initialization: ============================================================");

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
            Singleton4 fromTeacher = Singleton4.GetInstance;
            fromTeacher.PrintSomething("Hello fromTeacher");
        }

        private static void PrintStudentDetail()
        {
            Singleton4 fromStudent = Singleton4.GetInstance;
            fromStudent.PrintSomething("Hello fromStudent");
        }

        private static void PrintEmployeeDetail()
        {
            Singleton4 fromEmployee = Singleton4.GetInstance;
            fromEmployee.PrintSomething("Hello fromEmployee");
        }
    }
}
