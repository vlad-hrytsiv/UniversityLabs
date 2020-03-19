using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Task2
    {
        static void Main(string[] args)
        {
            string[] wordList = { "Кобзар", "Марiя", "Заповiт", "Словник", "Iнформатика" };

            FileStream groupFile = new FileStream("C:\\users\\admin\\documents\\task2.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(groupFile);

            foreach(string word in wordList)
            {
                writer.WriteLine(word);
            }

            writer.Close();
        }
    }
}
