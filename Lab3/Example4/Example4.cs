using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    class Example4
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int max = a > b ? a : b;

            Console.WriteLine("Максимальное число - "+max);
        }
    }
}
