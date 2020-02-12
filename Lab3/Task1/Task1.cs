using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Task1
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько голов забили хозяева? ");
            int goalsDwellers = Convert.ToInt32(Console.ReadLine());

            Console.Write("Сколько голов забили гостья? ");
            int goalsGuests = Convert.ToInt32(Console.ReadLine());

            if (goalsDwellers > goalsGuests)
            {
                Console.WriteLine("Хозяева победили!");
            } 
            else if (goalsDwellers < goalsGuests)
            {
                Console.WriteLine("Гостья победили!");
            } 
            else
            {
                Console.WriteLine("Ничья!");
            }
        }
    }
}
