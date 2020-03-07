using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Task1
    {
        static void Main(string[] args)
        {
            int[,] array = new int[6,6];
            int sum = 0;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("Enter element with index [{0}][{1}]: ", i,j);
                    int userInput = Convert.ToInt32(Console.ReadLine());

                    array[i, j] = userInput;

                    if (array[i, j] % 3 == 0)
                    {
                        sum += array[i, j];
                    }
                }
            }

            Console.WriteLine("\nYour array:");

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(array[i,j]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nSum: "+sum);
        }
    }
}
