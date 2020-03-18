using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Task9
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of elements of array: ");
            int userAmount = Convert.ToInt32(Console.ReadLine());

            int[] A = new int[userAmount];
            A = secondWay(A);

            Console.WriteLine("Initial array:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
                if (A[i] < 0)
                {
                    A[i] = 0;
                }
            }

            Console.WriteLine("\n\nElements with odd indexes:");

            for (int i = 0; i<A.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("Index of {0} is {1}", A[i], i);
                }
            }
        }

        static int[] secondWay(int[] arrayOfNumbers)
        {
            Random random = new Random();

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] = random.Next(1, 100);
            }
            return arrayOfNumbers;
        }
    }
}
