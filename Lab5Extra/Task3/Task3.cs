using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Task3
    {
        static void Main(string[] args)
        {
            for (int i = 100; i<=999; i++)
            {
                if (i%3 == 0 && i%7 == 0)
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}
