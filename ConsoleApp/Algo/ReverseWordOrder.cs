using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Algo
{
    class ReverseWordOrder
    {
        static void Main()
        {
            var InputStr = "Hello World DotNet Practice Algorithm";
            var Result = ReverseGivenWordOrder(InputStr);
            Console.WriteLine(InputStr);
            Console.WriteLine(Result);

            Console.ReadKey();

        }

        internal static string ReverseGivenWordOrder(string str)
        {
            //[1][2][3][4] : Size
            //[0][1][2][3] : Index
            string[] strArray = str.Split(' ');
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= strArray.Length - 1; i++)
            {
                char[] charArray = strArray[i].ToCharArray();
                for (int j = 0, k = charArray.Length - 1; j < k; j++, k--)
                {
                    var temp = charArray[j];
                    charArray[j] = charArray[k];
                    charArray[k] = temp;
                }
                sb.Append(charArray);
                sb.Append(' ');

            }

            return sb.ToString();
        }
    }
}
