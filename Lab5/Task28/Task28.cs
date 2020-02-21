using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task28
{
    class Task28
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number in decimal system: ");
            int decNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result in octal - " + Convert.ToString(decNumber, 8));
            Console.WriteLine("Result in binary - " + Convert.ToString(decNumber, 2));
            Console.WriteLine("Result in hexadecimal - " + Convert.ToString(decNumber, 16));
        }
    }
}
