using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Task3
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("C:\\users\\admin\\documents\\task2.txt");

            string maxString = "", tmpString;
            int maxLength = 0;

            while ((tmpString = file.ReadLine()) != null)
            {
                if (tmpString.Length > maxString.Length)
                {
                    maxString = tmpString;
                    maxLength = tmpString.Length;
                }
            }

            Console.WriteLine("Line with the max length - \"{0}\". It contains {1} character(s).", maxString, maxLength);
        }
    }
}
