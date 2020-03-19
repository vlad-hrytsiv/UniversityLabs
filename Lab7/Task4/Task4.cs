using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Task4
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.Write("What is the dimension of the matrix? ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[n, n];

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rand.Next(10);

                    if (i + j == n - 1)
                    {
                        sum += matrix[i, j];
                    }

                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nSum of elements of side diagonal is "+sum);
        }
    }
}
