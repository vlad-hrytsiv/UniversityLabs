using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func15
{
    class Func15
    {
        static void Main(string[] args)
        {
            for (double x = -5; x<=5; x += 0.5)
            {

                double u;

                if (x < -3)
                {
                    u = Math.Pow(x, 2) - x + 1;
                } else if (x > 3)
                {
                    u = Math.Sin(x - 1) + Math.Cos(x + 1);
                } else
                {
                    u = Math.Atan(x);
                }

                double mainFunction = 2.51 * Math.Pow(x, 2) * Math.Log(Math.Abs(8 - Math.Sin(u)), 10);
                Console.WriteLine(x+"\t"+mainFunction);
            }
        }
    }
}
