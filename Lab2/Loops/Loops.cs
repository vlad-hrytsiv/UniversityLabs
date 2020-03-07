using System;

namespace Loops
{
    class Loops
    {
        static void Main(string[] args)
        {
            Console.Write("Введите степень к которому подносить числа от 3 к 115: ");
            int userPow = Convert.ToInt32(Console.ReadLine());

            for (int i = 3; i <= 115; i++)
            {
                Console.WriteLine("Степень числа {0} равенн {1}", i, Math.Pow(i, userPow));
            }

            Console.Write("\nВведите степень к которому подносить все четные числа от 0 к 110: ");
            int userPow2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 110; i+=2)
            {
                Console.WriteLine("Степень числа {0} равен {1}", i, Math.Pow(i, userPow2));
            }
        }
    }
}
