using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Task2
    {
        static bool CheckNumber(int number)
        {
            if (number % 3 == 0 && number % 7 == 0)
            {
                return true;
            }

            return false;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (CheckNumber(a))
            {
                Console.WriteLine("Число кратное 3 и 7!");
            } else
            {
                Console.WriteLine("Число не подходит!");
            }
        }
    }
}
