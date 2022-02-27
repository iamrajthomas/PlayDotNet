using System;

namespace ConsoleApp.Practice.SingletonPattern
{
    /// <summary>
    /// Singleton with base variant [single threaded model]
    /// </summary>
    sealed class Singleton1
    {
        private static int counter = 0;
        private static Singleton1 Instance = null;
        public static Singleton1 GetInstance
        {
            get
            {
                if (Instance == null)
                    Instance = new Singleton1();
                return Instance;
            }
        }

        /// <summary>
        /// private ctor
        /// </summary>
        private Singleton1()
        {
            counter += 1;
            Console.WriteLine("Number of Instances created are: " + counter);
        }

        public void PrintSomething(string message)
        {
            Console.WriteLine(message);

        }

        /// <summary>
        /// Nested Class             
        /// Why The Singleton is Sealed 
        /// </summary>
        //public class DerivedSingleton : Singleton1 { }
    }
}
