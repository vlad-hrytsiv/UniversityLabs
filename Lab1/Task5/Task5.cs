using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Task5
    {
        static void Main(string[] args)
        {
            byte x;
            int sum;

            sum = 0;
            for (x = 1; x <= 100; x++)
            {
                sum = sum + x;
            }

            Console.WriteLine("Сума чисел вiд 0 до 100 дорiвнює " + sum);
        }
    }
}
