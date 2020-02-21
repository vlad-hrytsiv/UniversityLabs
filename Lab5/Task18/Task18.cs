using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18
{
    class Task18
    {
        static void Main(string[] args)
        {
            Console.Write("Enter student\'s savings: ");
            double S = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter student\'s scolarship: ");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter student\'s expenses: ");
            double B = Convert.ToDouble(Console.ReadLine());

            double expenses = B;
            double studentMoney = (A + S)*10;
            int monthCounter = 0;

            if (A < B)
            {
                while (studentMoney >= expenses)
                {
                    B = B + B * 0.03;
                    expenses = expenses + B;

                    studentMoney = studentMoney - expenses;
                    monthCounter++;
                }

                Console.WriteLine("Student will die in {0} months.", monthCounter);
            }
            else
            {
                throw new ArgumentException("A cannot be greater than B.");
            }
        }
    }
}
