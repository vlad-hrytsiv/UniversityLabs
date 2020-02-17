using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Замiненi слова:");

            string lineFirst = "Нiчого не буває просто так,";
            string lineSecond = "Нiчого не буває випадково:";
            string lineThird = "Нi зустрiч, нi подiя, анi слово...";
            string lineFourth = "До того йшло, або ж це Долi Знак";

            string[] textFirst = { lineFirst, lineSecond, lineThird, lineFourth };

            for (int i = 0; i < textFirst.Length; i++)
            {
                textFirst[i] = textFirst[i].Replace("Нiчого не", "Все");
                Console.WriteLine(textFirst[i]);
            }

            int theLongestNum = 0;
            string theLongestStr = "";

            for (int i = 0; i<textFirst.Length; i++)
            {
                if (textFirst[i].Length > theLongestNum)
                {
                    theLongestNum = textFirst[i].Length;
                    theLongestStr = textFirst[i];
                }
            }

            Console.WriteLine("\nНайдовша стрiчка - {0} \n", theLongestStr);

            Console.WriteLine("Без останнiх двох слiв: ");
            Console.WriteLine(lineFirst.Remove(16));
            Console.WriteLine(lineFirst.Remove(9));
            Console.WriteLine(lineFirst.Remove(22));
            Console.WriteLine(lineFirst.Remove(22)+"\n");

            Console.WriteLine("Приведенi до одного формату:");

            string nextLineFirst = "Я хочу, щоб у морi слiз,";
            string nextLineSecond = "У СВIТI, ДЕ ПАНУЄ ЛИХО,";
            string nextLineThird = "ПОЕЗIЇ РОСТОЧОК РIС:";
            string nextLineFourth = "Втiшав, нагадував i кликав.";

            nextLineSecond = nextLineSecond.Remove(2) + nextLineSecond.Substring(2).ToLower();
            nextLineThird = nextLineThird.Remove(1) + nextLineThird.Substring(2).ToLower();

            Console.WriteLine(nextLineFirst);
            Console.WriteLine(nextLineSecond);
            Console.WriteLine(nextLineThird);
            Console.WriteLine(nextLineFourth+"\n");

            Console.WriteLine("Iмена користувачiв: ");

            string userNames = "Login1, LOgin2, login3, loGin4";
            string[] arrayOfNames = userNames.Split(',');

            for (int i =0; i<arrayOfNames.Length; i++)
            {
                arrayOfNames[i] = arrayOfNames[i].Replace(" ", "");
                arrayOfNames[i] = arrayOfNames[i].ToLower();
                Console.WriteLine(arrayOfNames[i]);
            }
        }
    }
}
