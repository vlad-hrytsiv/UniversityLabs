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
            int iVar = 100;
            double dVar = 100.0;

            Console.WriteLine("Початкове значення змiнної iVar = " + iVar);
            Console.WriteLine("Початкове значення змiнної dVar = " + dVar);
            Console.WriteLine();

            iVar = iVar / 3;
            dVar = dVar / 3.0;

            Console.WriteLine("Пiсля дiлення значення змiнної iVar = " + iVar);
            Console.WriteLine("Пiсля дiлення значення змiнної dVar = " + dVar);
        }
    }
}
