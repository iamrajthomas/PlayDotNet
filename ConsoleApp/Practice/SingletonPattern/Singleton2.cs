using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Practice.SingletonPattern
{
    /// <summary>
    /// Singleton with 2nd base variant [multi threaded model]
    /// </summary>
    sealed class Singleton2 
    {
        private static int counter = 0;
        private static Singleton2 Instance = null;
        private static readonly object lockObject = new object();
        public static Singleton2 GetInstance 
        {
            get
            {
                if(Instance == null)
                {
                    lock (lockObject)
                    {
                        if (Instance == null)
                            Instance = new Singleton2();
                    }
                }
                return Instance;
            }
        }

        /// <summary>
        /// private ctor
        /// </summary>
        private Singleton2()
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
