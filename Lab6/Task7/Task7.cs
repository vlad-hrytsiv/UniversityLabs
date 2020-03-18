using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Task7
    {
        static void Main(string[] args)
        {
            int[] c = new int[23];
            c = secondWay(c);

            int sum = 0;

            Console.WriteLine("Initial array:");
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i] + " ");
                sum += c[i];
            }

            double average = sum / c.Length;

            Console.WriteLine("\n\nAverage: "+ average);
        }
        static int[] secondWay(int[] arrayOfNumbers)
        {
            Random random = new Random();

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] = random.Next(1, 101);
            }
            return arrayOfNumbers;
        }
    }
}
