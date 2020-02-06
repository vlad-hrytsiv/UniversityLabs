using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Task8
    {
        static void Main(string[] args)
        {
            double radius = 10.0;
            double area = Math.Pow(radius, 2) * Math.PI;

            double rounded_area = Math.Round(area, 2);

            Console.WriteLine("Площа = " + rounded_area);
        }
    }
}
