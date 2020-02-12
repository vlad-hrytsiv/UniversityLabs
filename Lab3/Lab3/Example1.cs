using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Example1
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 2;
            b = 3;
            if (a < b) Console.WriteLine("Значение переменной a меньше, чем " +
                                                                "значение переменной  b.");
            //Рядок приведений в якосты параметру
            //в наступному методі WriteLine (), не буде виведений на екран. 
            if (a == b) Console.WriteLine("эта строка не будет выведена на экран");
            Console.WriteLine();
            c = a - b;   //змінна, що присвоює значення -1.
            Console.WriteLine("переменная с имеет значение - 1.");
            if (c >= 0) Console.WriteLine("значение переменной  c = " +
                                                                "не отрицательное число.");
            if (c < 0) Console.WriteLine("значение переменной  c = " +
                                                                " отрицательное число.");
            Console.WriteLine();

            c = b - a;   //змінна, що присвоює значення 1.
            Console.WriteLine("переменная с имеет значение 1.");
            if (c >= 0) Console.WriteLine("значение переменной  c = " +
                                                                "не отрицательное число.");
            if (c < 0) Console.WriteLine("значение переменной  c = " +
                                                                " отрицательное число.");

        }
    }
}
