using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Task2
    {
        static void Main(string[] args)
        {
            int[] a = new int[11];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i;
                a[i] = a[i] * a[i];
                Console.WriteLine(a[i]);
            }
        }
    }
}
