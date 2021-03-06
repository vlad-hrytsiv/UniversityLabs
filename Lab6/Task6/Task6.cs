﻿using System;

namespace Task6
{
    class Task6
    {
        static void Main(string[] args)
        {
            int[] c = new int[25];
            c = secondWay(c);

            Console.WriteLine("Initial array:");
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i] + " ");
            }

            c = SelectionSort(c);

            Console.WriteLine("\n\nSorted array:");

            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i] + " ");
            }

            int prod = 1;

            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] % 5 == 0)
                {
                    prod = prod * c[i];
                }
            }
            Console.WriteLine("\n\nProduct of all elements can be divided to 5: " + prod);
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

        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        static int IndexOfMin(int[] array, int n)
        {
            int result = n;
            for (var i = n; i < array.Length; ++i)
            {
                if (array[i] < array[result])
                {
                    result = i;
                }
            }

            return result;
        }

        static int[] SelectionSort(int[] array, int currentIndex = 0)
        {
            if (currentIndex == array.Length)
                return array;

            var index = IndexOfMin(array, currentIndex);
            if (index != currentIndex)
            {
                Swap(ref array[index], ref array[currentIndex]);
            }

            return SelectionSort(array, currentIndex + 1);
        }
    }
}
