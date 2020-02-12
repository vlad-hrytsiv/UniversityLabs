using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько вложить денег? ");
            double depositValue = Convert.ToDouble(Console.ReadLine());

            if (depositValue > 2000)
            {
                throw new ArgumentException("Сумма вложения не может быть больше чем 2000!");
            }

            double withdrawUAH, withdrawEUR, withdrawUSD;

            withdrawUAH = depositValue + depositValue * 0.1;
            withdrawEUR = (depositValue + depositValue * 0.11) * 26.7;
            withdrawUSD = (depositValue + depositValue * 0.15) * 24.25;

            Console.WriteLine("Если вложить {0} гривен, Вы получите {1} грн.", depositValue, withdrawUAH);
            Console.WriteLine("Если вложить {0} евро, Вы получите {1} грн.", depositValue, withdrawEUR);
            Console.WriteLine("Если вложить {0} долларов, Вы получите {1} грн.", depositValue, withdrawUSD);

            if (withdrawUAH > withdrawEUR && withdrawUAH > withdrawUSD)
            {
                Console.WriteLine("Самый выгодной вклад в гривне!");
            } else if  (withdrawEUR > withdrawUAH && withdrawEUR > withdrawUSD)
            {
                Console.WriteLine("Самый выгодной вклад в евро!");
            } else
            {
                Console.WriteLine("Самый выгодной вклад в долларах!");
            }
        }
    }
}
