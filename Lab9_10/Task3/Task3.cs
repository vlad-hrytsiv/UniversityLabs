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
            Console.WriteLine(FindFibonacci(16));
        }

        static int FindFibonacci(int n)
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
