using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expressions
{
    class Expressions
    {
        static void Main(string[] args)
        {
            double x = 1.573;
            double a = 1.775;

            // Перший вираз
            double numeratorFirst = Math.Pow(a + x, 3) * Math.Log((a + x) / 2);
            double denumeratorFirst = Math.Pow(1 + Math.Pow(a + Math.Pow(x, 3), 2) / 4, 1 / 3f);

            double Y1 = numeratorFirst / denumeratorFirst;
            Console.WriteLine(Y1);

            // Другий вираз
            double Y2 = 2 * Math.Pow(x, 3) + (2 * Math.Pow(a, 4) / Math.Pow(1 + Math.Pow(x, 3), 1 / 3f)) * Math.Pow(Math.E, -(Math.Pow(a, 2) + 1) / 2);
            Console.WriteLine(Y2);

            // Третій вираз
            double numeratorThird = 1 + Math.Pow(Math.Tan((x + 1) / 4), 2);
            double denumeratorThird = 1 + (Math.Pow(a, 3) + 1) / 4;

            double Y3 = Math.Pow((numeratorThird / denumeratorThird), 1 / 4f) * Math.Pow(Math.E, -(x + 1) / 4);
            Console.WriteLine(Y3);

            // Четвертий вираз
            double numeratorFourth = Math.Pow(Math.E, (5 * Math.Pow(x, 2)) / 2) + Math.Pow(Math.E, 1 + (4 * Math.Pow(a, 3)) / 2);
            double denumeratorFourth = 1 + Math.Pow(x, 2) / 2 + Math.Pow(Math.Pow(a, 3) / 2, 2);

            double Y4 = numeratorFourth / denumeratorFourth;
            Console.WriteLine(Y4);
        }
    }
}
