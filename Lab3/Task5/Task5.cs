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
            Console.Write("Введите число А: ");
            int userValue = Convert.ToInt32(Console.ReadLine());

            bool expressionFirst = false; 
            bool expressionSecond = false; 
            bool expressionThird = false;

            if (userValue % 2 == 0)
            {
                if (userValue % 3 != 0)
                {
                    if (userValue % 4 == 0)
                    {
                        expressionFirst = true;
                    }
                }
            }

            if (userValue % 7 == 0)
            {
                if (userValue % 4 != 0)
                {
                    expressionSecond = true;
                }
            }

            if (userValue % 2 == 0)
            {
                if (userValue % 14 == 0)
                {
                    expressionThird = true;
                }
            }

            bool finalExpression = expressionFirst && expressionSecond && expressionThird;

            if (finalExpression)
            {
                Console.WriteLine("Логическое выражение есть истенным!");
            } else
            {
                Console.WriteLine("Логическое выражение не может быть истенным!");
            }
        }
    }
}
