using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskExtra
{
    class TaskExtra
    {
        static void Main(string[] args)
        {
            /* Перше і друге завдання */

            Console.Write("Введiть число: ");
            double userInput = Convert.ToDouble(Console.ReadLine()); // Приймає число користувача

            Console.WriteLine("Ваше число з точнiстю до сотих - " + Math.Round(userInput, 2)); // Округлює його до сотих
            Console.WriteLine("Ваше число з точнiстю до десятих - " + Math.Round(userInput, 1)); // Округлює його до десятих

            /* Третє завдання */
            int a = 1;
            int b = 13;
            int c = 49;

            Console.WriteLine(a + " " + b + " " + c);

            /* Четверте завдання */
            Console.WriteLine("50");
            Console.WriteLine("10");

            /* П'яте завдання */
            Console.WriteLine("5 10");
            Console.WriteLine("7 см");

            Console.Write("Введiть значення t: ");
            int t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("100 " + t);

            Console.Write("Введiть значення v: ");
            int v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1949 " + v);

            Console.Write("Введiть значення x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x + " 25");

            Console.Write("Введiть значення y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x + " " + y);

            /* Шосте завдання */
            Console.Write("Введiть суму, яку вкладе пiдприємство: ");
            int s = Convert.ToInt32(Console.ReadLine());
            double profit = s + (s * 0.4);
            Console.WriteLine("Пiдприємство отримає в кiнцi року: " + profit);
        }
    }
}
