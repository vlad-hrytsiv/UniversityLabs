﻿using System;
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
            int[] c = new int[19];
            int sum = 0;
            long prod = 1;

            Console.WriteLine("Choose an array filling method");
            Console.WriteLine("1 - Filling with values from [1..19]");
            Console.WriteLine("2 - Filling with random values [1..10]");
            Console.WriteLine("3 - Filling with your values");

            Console.Write("\nYour choice: ");
            byte userChoice = Convert.ToByte(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    firstWay(c);
                    break;
                case 2:
                    secondWay(c);
                    break;
                case 3:
                    thirdWay(c);
                    break;
                default:
                    throw new ArgumentException("You must enter 1, 2 or 3!");
            }

            Console.WriteLine("Elements of array: ");

            for (int i = 0; i<c.Length; i++)
            {
                Console.Write(c[i] +" ");
            }

            foreach (int value in c)
            {
                sum = sum + value;
                prod = prod * value;
            }

            Console.WriteLine("\n\nSum of elements  = " + sum);
            Console.WriteLine("Product of elements = " + prod);
        }

        static int[] firstWay (int[] arrayOfNumbers)
        {
            arrayOfNumbers[0] = 1;
            arrayOfNumbers[1] = 2;
            arrayOfNumbers[2] = 3;
            arrayOfNumbers[3] = 4;
            arrayOfNumbers[4] = 5;
            arrayOfNumbers[5] = 6;
            arrayOfNumbers[6] = 7;
            arrayOfNumbers[7] = 8;
            arrayOfNumbers[8] = 9;
            arrayOfNumbers[9] = 10;
            arrayOfNumbers[10] = 11;
            arrayOfNumbers[11] = 12;
            arrayOfNumbers[12] = 13;
            arrayOfNumbers[13] = 14;
            arrayOfNumbers[14] = 15;
            arrayOfNumbers[15] = 16;
            arrayOfNumbers[16] = 17;
            arrayOfNumbers[17] = 18;
            arrayOfNumbers[18] = 19;
            return arrayOfNumbers;
        }
        static int[] secondWay(int[] arrayOfNumbers)
        {
            Random random = new Random();

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] = random.Next(1, 11);
            }
            return arrayOfNumbers;
        }

        static int[] thirdWay(int[] arrayOfNumbers)
        {
            Console.WriteLine("Input your values:");

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                arrayOfNumbers[i] = userInput;
            }
            return arrayOfNumbers;
        }
    }
}
