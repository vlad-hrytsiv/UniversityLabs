using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Task2
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] array = new int[2, 4];
            int sum = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    array[i, j] = rand.Next(10);

                    if (j == 1 || j == 3)
                    {
                        sum += array[i, j];
                    }
                }
            }

            Console.WriteLine("Array:");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nSum of elements from 2nd and 4th column: "+sum);
        }
    }
}
