using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Task2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            int minimal = MinimalNumber(firstNumber, secondNumber, thirdNumber);

            Console.WriteLine("Minimal number is "+minimal);
        }

        static int MinimalNumber(int firstValue, int secondValue, int thirdValue)
        {
            if (firstValue < secondValue && firstValue < thirdValue)
            {
                return firstValue;
            } else if (secondValue < firstValue && secondValue < thirdValue)
            {
                return secondValue;
            } else
            {
                return thirdValue;
            }
        }
    }
}
