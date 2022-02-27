using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    /// <summary>
    /// Singleton with multi threaded model with Lazy Initialization
    /// </summary>
    public sealed class Log : ILog
    {
        //this is Lazy Initialization
        private static readonly Lazy<Log> Instance = new Lazy<Log>(() => new Log());
        public static Log GetInstance
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
        private Log()
        {
        }

        public void PrintSomething(string message)
        {
            Console.WriteLine(message);

        }

        public void LogException(string message)
        {
            string FileName = string.Format("{0}_{1}_{2}.log", "Exception", DateTime.Now.ToString("dddd, dd MMMM yyyy"), Guid.NewGuid());
            string LogFilePath = string.Format(@"{0}\{1}", AppDomain.CurrentDomain.BaseDirectory, FileName);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("========================================================");
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine(message);
            using (StreamWriter writer = new StreamWriter(LogFilePath, true))
            {
                writer.Write(sb.ToString());
                writer.Flush();
            }
        }
    }
}
