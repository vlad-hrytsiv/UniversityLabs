using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Extra
{
    class Lab5Extra
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A number: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter B number: ");
            int B = Convert.ToInt32(Console.ReadLine());

            if (A >= B)
            {
                throw new ArgumentException("A must be lesser than B");
            }

            int numOfItems = 0;

            for (int i = A; i <= B; i++)
            {
                Console.WriteLine(i);
                numOfItems++;
            }

            Console.WriteLine("Amount of elements - {0}", numOfItems);
        }
    }
}
