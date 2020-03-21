using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Task3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of element: ");
            int userValue = Convert.ToInt32(Console.ReadLine());

            if (userValue < 1)
            {
                throw new ArgumentException("The position cannot be smaller than 1!");
            }
            Console.WriteLine(FindFibonacci(userValue));
        }

        static long FindFibonacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return FindFibonacci(n - 1) + FindFibonacci(n - 2);
            }
        }
    }
}
