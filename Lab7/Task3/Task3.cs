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
            Random rand = new Random();
            int[] A = new int[9];
            int sum = 0;
            int positiveProd = 1;

            for (int i = 0; i<A.Length; i++)
            {
                A[i] = rand.Next(-10,10);
                sum += A[i];

                Console.Write(A[i]+" ");

                if (A[i] > 0)
                {
                    positiveProd = positiveProd * A[i];
                }
            }

            double average = sum / A.Length;
            Console.WriteLine("\nAverage number: "+average);
            Console.WriteLine("Product of positive numbers: "+positiveProd);
        }
    }
}
