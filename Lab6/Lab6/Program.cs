using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] c = new int[19];
            int sum = 0;
            int prod = 1;

            /*Заповнив масив*/
            for (int i = 0; i<c.Length; i++)
            {
                c[i] = i + 1;
            }

            foreach (int value in c)
            {
                sum = sum + value;
                prod = prod * value;
            }

            Console.WriteLine("Sum of elements [1..19] = "+sum);
            Console.WriteLine("Production of elements [1..19] = "+prod);

        }
    }
}
