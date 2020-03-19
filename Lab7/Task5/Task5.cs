using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Task5
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.Write("What is the dimension of the matrix? ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[n, n];

            bool containsPositive = false;
            long prod = 1;

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rand.Next(-9, 9);

                    // Для зручного виводу у вигляді таблиці до невід'ємних значень додаємо відступ
                    if (matrix[i, j] >= 0)
                    {
                        Console.Write(" " + matrix[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    // Кінець виводу у вигляді таблиці

                    if (i == j && matrix[i,j] > 0)
                    {
                        prod *= matrix[i, j];
                        containsPositive = true;
                    }
                }

                int rowMin = matrix[i, 0];
                int rowMinPosition = 0;

                for (int k = 0; k < n; k++)
                {
                    if (matrix[i, k] < n)
                    {
                        rowMin = matrix[i, k];
                        rowMinPosition = k;
                    }
                }
                Console.WriteLine("\tMinimal value - {0} with position {1}", rowMin, rowMinPosition);
            }

            if (!containsPositive)
            {
                prod = 0;
            }
            Console.WriteLine("\nProduct of positive elements of main diagonal is "+prod);
        }
    }
}
