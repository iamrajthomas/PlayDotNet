using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Practice.SingletonPattern
{
    /// <summary>
    /// Singleton with multi threaded model with Lazy Initialization
    /// </summary>
    sealed class Singleton4
    {
        private static int counter = 0;
        //private static readonly Singleton4 Instance = new Singleton4(); //this is Non-Lazy Initialization

        //this is Lazy Initialization
        private static readonly Lazy<Singleton4> Instance = new Lazy<Singleton4>(() => new Singleton4()); 
        public static Singleton4 GetInstance
        {
            get
            {
                //Lazy type can be accessed with Value prop
                return Instance.Value; 
            }
        }

        /// <summary>
        /// private ctor
        /// </summary>
        private Singleton4()
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
