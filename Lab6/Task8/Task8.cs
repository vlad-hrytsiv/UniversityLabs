using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Task8
    {
        static void Main(string[] args)
        {
            int[] c = new int[15];
            c = secondWay(c);

            Console.WriteLine("Initial array:");
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i] + " ");
                if (c[i] < 0)
                {
                    c[i] = 0;
                }
            }

            Console.WriteLine("\n\nFinal array:");
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i] + " ");
            }
        }

        static int[] secondWay(int[] arrayOfNumbers)
        {
            Random random = new Random();

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] = random.Next(-15, 15);
            }
            return arrayOfNumbers;
        }
    }
}
