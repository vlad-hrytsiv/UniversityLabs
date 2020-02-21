using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17
{
    class Task17
    {
        static void Main(string[] args)
        {
            Console.Write("Enter student\'s scolarship: ");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter student\'s expenses: ");
            double B = Convert.ToDouble(Console.ReadLine());

            double expenses = B;

            if (A < B)
            {
                for (int i=0; i<9; i++)
                {
                    B = B + B * 0.03;
                    expenses = expenses + B;
                }
            } else
            {
                throw new ArgumentException("A cannot be greater than B.");
            }

            double extraMoney = expenses - A*10;
            Console.WriteLine("In addition to the scholarship student need to have {0:N2} CU.", extraMoney);
        }
    }
}
