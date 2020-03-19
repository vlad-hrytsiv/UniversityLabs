using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Task4
    {
        static void Main(string[] args)
        {
            int[] c = new int[79];
            c = secondWay(c);

            Console.WriteLine("Initial array:");
            for (int i = 0; i<c.Length; i++){
                Console.Write(c[i]+" ");
            }

            c = SelectionSort(c);
            
            Console.WriteLine("\n\nSorted array:");

            for (int i = 0; i<c.Length; i++){
                Console.Write(c[i]+" ");
            }

            int evenSum = 0;

            for (int i = 0; i<c.Length; i++){
                if (c[i]%2==0){
                    evenSum+=c[i];
                }
            }

            Console.WriteLine("\n\nSum of even elements: "+evenSum);
        }

        static int[] secondWay(int[] arrayOfNumbers)
        {
            Random random = new Random();

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] = random.Next(1, 101);
            }
            return arrayOfNumbers;
        }

        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        static int IndexOfMin(int[] array, int n)
        {
            int result = n;
            for (var i = n; i < array.Length; ++i)
            {
                if (array[i] < array[result])
                {
                    result = i;
                }
            }

            return result;
        }

        static int[] SelectionSort(int[] array, int currentIndex = 0)
        {
            if (currentIndex == array.Length)
                return array;

            var index = IndexOfMin(array, currentIndex);
            if (index != currentIndex)
            {
                Swap(ref array[index], ref array[currentIndex]);
            }

            return SelectionSort(array, currentIndex + 1);
        }
    }
}
