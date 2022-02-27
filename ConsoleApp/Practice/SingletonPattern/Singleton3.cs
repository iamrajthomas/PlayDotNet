using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Practice.SingletonPattern
{
    /// <summary>
    /// Singleton with multi threaded model with Non-Lazy Initialization
    /// </summary>
    sealed class Singleton3
    {
        private static int counter = 0;
        private static readonly Singleton3 Instance = new Singleton3(); //this is Non-Lazy Initialization
        public static Singleton3 GetInstance
        {
            get
            {
                return Instance;
            }
        }

        /// <summary>
        /// private ctor
        /// </summary>
        private Singleton3()
        {
            counter += 1;
            Console.WriteLine("Number of Instances created are: " + counter);
        }

        public void PrintSomething(string message)
        {
            Console.WriteLine(message);

        }
    }
}
