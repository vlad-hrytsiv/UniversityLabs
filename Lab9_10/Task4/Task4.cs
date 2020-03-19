using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class House
    {
        public int numberOfPeople;
        public int area;
        public int numberOfFloors;
    }
    class Task4
    {
        static void Main(string[] args)
        {
            House h1 = new House { numberOfPeople = 312, area = 12789, numberOfFloors = 20 };

            double areaPerHuman = Convert.ToDouble(h1.area) / Convert.ToDouble(h1.numberOfPeople);
            areaPerHuman = Math.Round(areaPerHuman, 2);
            Console.WriteLine("There are {0} tenants, area is {1} and number of floors is {2}", h1.numberOfPeople, h1.area, h1.numberOfFloors);
            Console.WriteLine("Area per one tenant is "+areaPerHuman);
        }
    }
}
