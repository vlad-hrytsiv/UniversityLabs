using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class SICS // Security of information and communication systems
    {
        public string fullName { get; set; }
        public DateTime birthDate { get; set; }
        public string birthCity { get; set; }
        public string phoneNumber { get; set; }
        public string hairColor { get; set; }

        public override string ToString()
        {
            return String.Format("Student's full name is {0}, \nDate of birth: {1}, \nCity of birth: {2}, \nPhone number: {3}, \nHair is {4}.", fullName, birthDate, birthCity, phoneNumber, hairColor);
        }

        public void GetProperDate()
        {
            if (birthDate.Year > 1996)
            {
                Console.WriteLine("{0} was born after 1996!", fullName);
            }
        }
    }
    class Task7
    {
        static void Main(string[] args)
        {
            SICS student1 = new SICS();
            student1.fullName = "Stepan Antonovych Radchenko";
            student1.birthDate = DateTime.Parse("03.09.1994");
            student1.birthCity = "Kyiv";
            student1.phoneNumber = "+380994388293";
            student1.hairColor = "brown";

            SICS student2 = new SICS();
            student2.fullName = "Olexandr Ivanovych Shevchenko";
            student2.birthDate = DateTime.Parse("23.02.1998");
            student2.birthCity = "Lviv";
            student2.phoneNumber = "+380682732713";
            student2.hairColor = "blond";

            SICS student3 = new SICS();
            student3.fullName = "Dmytro Artemovych Karpenko";
            student3.birthDate = DateTime.Parse("13.12.2002");
            student3.birthCity = "Dnirpo";
            student3.phoneNumber = "+380679384722";
            student3.hairColor = "red";

            SICS[] students = new SICS[3];
            students[0] = student1;
            students[1] = student2;
            students[2] = student3;

            Console.WriteLine(student1.ToString());
            Console.WriteLine("\n"+student2.ToString());
            Console.WriteLine("\n"+student3.ToString());

            Console.WriteLine();

            foreach (SICS student in students)
            {
                student.GetProperDate();
            }
        }
    }
}
