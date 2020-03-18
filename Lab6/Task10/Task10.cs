using System;

namespace Task10
{
    class Task10
    {
        static void Main(string[] args)
        {
            int[] c = new int[20];
            c = secondWay(c);

            Console.WriteLine("Initial array:");
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i] + " ");
            }

            long prod = 1;

            for (int i = 0; i < c.Length; i++)
            {
                if (i % 2 == 0)
                {
                    prod = prod * c[i];
                }
            }
            Console.WriteLine("\n\nProduct of all elements with even index: " + prod);
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
