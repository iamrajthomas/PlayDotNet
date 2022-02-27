using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Practice.SingletonPattern
{
    class TestSingleton1
    {
        static void Main()
        {
            Console.WriteLine("Singleton with base variant [single threaded model]: ============================================================");

            Singleton1 s1 = Singleton1.GetInstance;
            s1.PrintSomething("Hello from S1");

            Singleton1 s2 = Singleton1.GetInstance;
            s2.PrintSomething("Hello from S2");

            Console.WriteLine("============================================================");

            //Singleton1.DerivedSingleton derivedSingleton = new Singleton1.DerivedSingleton();
            //derivedSingleton.PrintSomething("Hello from derivedSingleton");

            Console.ReadLine();
        }
    }
}
