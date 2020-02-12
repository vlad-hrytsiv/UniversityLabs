using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Task5
    {
        static bool CheckExpression(int number){
            if (number % 2 == 0){
                if (number % 3 != 0 && number % 4 == 0){
                    return true;
                } else if (number % 7 == 0 && number % 4 != 0) {
                    return true;
                } else if (number % 2 == 0 && number % 14 == 0){
                    return true;
                } else {
                    return false;
                }
            } else {
                return false;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите число А: ");
            int userValue = Convert.ToInt32(Console.ReadLine());
            if (CheckExpression(userValue)){
                Console.WriteLine("Выражение истенное!");
            } else {
                Console.WriteLine("Выражение ложное!");
            }
        }
    }
}
