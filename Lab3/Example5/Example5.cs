using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example5
{
    class Example5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Модули чисел от -5 до 5:");
            for (int i = 5; i>=-5; i--)
            {
                int result = i >= 0 ? i : -i;
                Console.WriteLine("|{0}| = {1}", i, result);
            }
            Console.WriteLine("Выбераем четные числа от 1 до 9:");
            for (int i = 0; i<10; i++)
            {
                if (i%2 == 0 ? true : false)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
