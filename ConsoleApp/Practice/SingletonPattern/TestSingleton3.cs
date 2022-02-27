using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Practice.SingletonPattern
{
    class TestSingleton3
    {
        static void Main()
        {
            Console.WriteLine("Singleton with multi threaded model with Non-Lazy Initialization: ============================================================");

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
            Singleton3 fromTeacher = Singleton3.GetInstance;
            fromTeacher.PrintSomething("Hello fromTeacher");
        }

        private static void PrintStudentDetail()
        {
            Singleton3 fromStudent = Singleton3.GetInstance;
            fromStudent.PrintSomething("Hello fromStudent");
        }

        private static void PrintEmployeeDetail()
        {
            Singleton3 fromEmployee = Singleton3.GetInstance;
            fromEmployee.PrintSomething("Hello fromEmployee");
        }
    }
}
