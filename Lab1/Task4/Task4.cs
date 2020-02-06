using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Task4
    {
        static void Main(string[] args)
        {
            int prod = 1;
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;
                prod = prod * i;
            }

            Console.WriteLine("Сума = " + sum);
            Console.WriteLine("Добуток = " + prod);
        }
    }
}
