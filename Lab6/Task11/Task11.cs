using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Task11
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

            int arrayGreatest = findGreatest(c);
            int arrayLowest = findLowest(c);
            int sum = 0;

            if (arrayGreatest > arrayLowest)
            {
                for (int i = arrayLowest; i<arrayGreatest; i++)
                {
                    sum += c[i];
                }
            } else
            {
                for (int i = arrayGreatest; i < arrayLowest; i++)
                {
                    sum += c[i];
                }
            }

            Console.WriteLine("\n\nSum between {0} and {1} indexes is {2}", arrayGreatest, arrayLowest, sum);

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

        static int findLowest(int[] arrayOfNumbers)
        {
            int lowest = arrayOfNumbers[0];
            int lowestPosition = 0;

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] < lowest)
                {
                    lowest = arrayOfNumbers[i];
                    lowestPosition = i;
                }
            }

            return lowestPosition;
        }

        static int findGreatest(int[] arrayOfNumbers)
        {
            int greatest = 0;
            int greatestPosition = 0;

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] > greatest)
                {
                    greatest = arrayOfNumbers[i];
                    greatestPosition = i;
                }
            }

            return greatestPosition;
        }
    }
}
