using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Example
    {
        static void Main(string[] args)
        {
            double gradus = 30;
            double radian = gradus * Math.PI / 180;
            double x = 1;
            double x2 = Math.Sqrt(3);

            Console.WriteLine("Cos: " + Math.Cos(radian));
            Console.WriteLine("Sin: " + Math.Sin(radian));
            Console.WriteLine("Tan: " + Math.Tan(radian));
            Console.WriteLine("cTan: " + 1 / Math.Cos(radian));

            Console.WriteLine("ACos: " + Math.Acos(x) * 180 / Math.PI);
            Console.WriteLine("ASin: " + Math.Asin(x) * 180 / Math.PI);
            Console.WriteLine("ATan: " + Math.Atan(x2) * 180 / Math.PI);
            Console.WriteLine("ACTan: " + 1 / (Math.Atan(x2) * 180 / Math.PI));
        }
    }
}
