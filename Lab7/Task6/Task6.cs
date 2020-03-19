using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Task6
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.Write("What is the dimension of the matrix? ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[n, n];
            List<int> positiveRows = new List<int>();

            bool containsNegative = false;
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

                    if (i == j && matrix[i, j] < 0)
                    {
                        prod *= matrix[i, j];
                        containsNegative = true;
                    }

                    bool rowContainsPositive = false;

                    for (int k = 0; k < n; k++)
                    {
                        if (matrix[i, k] > 0)
                        {
                            rowContainsPositive = true;
                        }
                    }

                    if (rowContainsPositive && !positiveRows.Contains(i))
                    {
                        positiveRows.Add(i);
                    }
                }

                Console.WriteLine();
            }

            if (!containsNegative)
            {
                prod = 0;
            }

            Console.WriteLine("\nProduct of negative elements of main diagonal is " + prod);
            Console.WriteLine("Rows with positive numbers are: ");
            positiveRows.ForEach(Console.WriteLine);
        }
    }
}
