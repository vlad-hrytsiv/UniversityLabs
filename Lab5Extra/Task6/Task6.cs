using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Task6
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A number: ");
            int A = Convert.ToInt32(Console.ReadLine());

            if (A < 1)
            {
                throw new ArgumentException("A must be greater than 1!");
            }

            double sum = 0;
            double N;

            for (double i = 1; ; i++)
            {
                sum = sum + 1 / i;
                N = i;

                Console.WriteLine(sum);

                if (sum > A)
                {
                    break;
                }
            }

            Console.WriteLine("Sum = {0}, N = {1}", sum, N);
        }
    }
}
