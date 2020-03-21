using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Student
    {
        public string name;
        public int yearOfBirth;
        public byte[] grades = new byte[4];

        public Student()
        {
            this.name = "Default user name";
        }

        public Student(string name, int yearOfBirth, byte[] grades)
        {
            this.name = name;
            this.yearOfBirth = yearOfBirth;
            this.grades = grades;
        }

        public void SetUserValues()
        {
            Console.Write("Enter student's name: ");
            name = Console.ReadLine();

            if (string.IsNullOrEmpty(name)) throw new ArgumentException("You didn't write anything!");

            Console.Write("Enter student's year of birth: ");
            yearOfBirth = Convert.ToInt32(Console.ReadLine());

            if (yearOfBirth == 0) throw new ArgumentException("You didn't write anything!");

            for (int i = 0; i<grades.Length; i++)
            {
                Console.Write("{0}) Enter a new grade: ", i+1);

                grades[i] = Convert.ToByte(Console.ReadLine());

                if(grades[i] == 0) throw new ArgumentException("You didn't write anything!");
            }
        }

        public override string ToString()
        {
            return String.Format("{0} was born in {1}", name, yearOfBirth);
        }
    }
    class Task8
    {
        static void Main(string[] args)
        {
            Console.Write("How many students will you set? ");
            int n = Convert.ToInt32(Console.ReadLine());

            List<Student> group = new List<Student>();

            for (int i = 0; i<n; i++)
            {
                group.Add(new Student());
                group[i].SetUserValues();
                Console.WriteLine();
            }

            Console.WriteLine("List of the group beggins from the youngest:");

            List<Student> stortedGroup = group.OrderBy(o => o.yearOfBirth).ToList();
            stortedGroup.ForEach(Console.WriteLine);
        }
    }
}
