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
            int[] numbers = { 43, 56, -88, 26, 27, 366, 27, -4, 0, 11, 56, 27 };

            Console.WriteLine("Initial array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.Write("\n\nEnter a number you want to reverse: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            int[] reversedArray = Reverse(numbers, userInput);

            Console.WriteLine("\nFinal array:");
            for (int i = 0; i<reversedArray.Length; i++)
            {
                Console.Write(reversedArray[i]+" ");
            }

            Console.WriteLine("\n");
        }

        static int[] Reverse(int[] arrayOfIntegers, int valueToReverse)
        {
            for (int i = 0; i<arrayOfIntegers.Length; i++)
            {
                if (arrayOfIntegers[i] == valueToReverse)
                {
                    arrayOfIntegers[i] = arrayOfIntegers[i] * (-1);
                }
            }

            return arrayOfIntegers;
        }
    }
}
