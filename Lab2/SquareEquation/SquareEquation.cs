using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareEquation
{
    class SquareEquation
    {
        static void Main(string[] args)
        {
            Console.Write("Введите А: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите C: ");
            int c = Convert.ToInt32(Console.ReadLine());

            double D = Math.Pow(b, 2) - 4 * a * c;

            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);

            Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
        }
    }
}
