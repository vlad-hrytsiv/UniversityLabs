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
            Random rand = new Random();

            Console.Write("How many rows matrix contains? ");
            int userRows = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many columns matrix contains? ");
            int userColumns = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[userRows, userColumns];
            int negativeAmount = 0;

            int theLowest = matrix[0, 0];
            int theLowestRow = 0;
            int theLowestColumn = 0;

            for (int i = 0; i < userRows; i++)
            {
                for (int j = 0; j < userColumns; j++)
                {
                    matrix[i, j] = rand.Next(-9, 9);

                    if (matrix[i,j] < theLowest)
                    {
                        theLowest = matrix[i, j];
                        theLowestRow = i;
                        theLowestColumn = j;
                    }

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
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < userColumns; i++)
            {
                for (int j = 0; j < userRows; j++)
                {
                    if (matrix[j, i] < 0)
                    {
                        negativeAmount++;
                    }
                }
                
                Console.WriteLine("Amount of negative elements of the {0} column is {1}", i, negativeAmount);
                negativeAmount = 0;
            }

            Console.WriteLine("\nThe lowest element is {0} with index [{1}][{2}]", theLowest, theLowestRow, theLowestColumn);
        }
    }
}
