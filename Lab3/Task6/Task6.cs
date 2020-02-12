using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Task6
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько прошло дней (от 1 к 31)? ");
            int m = Convert.ToInt32(Console.ReadLine());

            if ( m >= 1 && m <= 31 ){
                DateTime previousDate = new DateTime(2018, 05, 04);
                DateTime currentDate = previousDate.AddDays(m);

                Console.WriteLine(currentDate);
            } else {
                throw new ArgumentException("Число m должно быть от 1 до 31.");
            }

         
        }
    }
}
