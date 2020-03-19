using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Task1
    {
        static void Main(string[] args)
        {
            FileStream groupFile = new FileStream("C:\\users\\admin\\documents\\group.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(groupFile);

            for (int i = 1; i <= 523; i++)
            {
                if (i == 523)
                {
                    writer.Write(i);
                    break;
                }
                writer.Write(i+", ");
            }

            writer.Close();
        }
    }
}
