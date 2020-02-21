using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func7
{
    class Func7
    {
        static void Main(string[] args)
        {
            for (double x = 0; x <= 4; x += 0.4)
            {

                double u;

                if (x <= 1.5)
                {
                    u = Math.Pow(x, 2) - x + 1;
                }
                else if (x > 2.5)
                {
                    u = Math.Pow(Math.Sin(x - 1), 3) + Math.Cos(x + 1);
                }
                else
                {
                    u = Math.Atan(x);
                }

                double mainFunction = 1.5 + Math.Log(Math.Abs(Math.Sin(u)));
                Console.WriteLine(x + "\t" + mainFunction);
            }
        }
    }
}
