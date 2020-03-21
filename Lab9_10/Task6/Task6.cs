using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Menu
    {
        private string name { get; set; }
        private string date { get; set; }
        private int price { get; set; }
        private double volume { get; set; }
        private string type { get; set; }

        public override string ToString()
        {
            return String.Format("Beverage's name: {0}, production date: {1}, price: {2}, volume: {3}, type: {4}", name, date, price, volume, type);
        }

        public void SetUserValues()
        {
            Console.Write("Enter beverage's name: ");
            name = Console.ReadLine();

            if (string.IsNullOrEmpty(name)) throw new ArgumentException("You didn't write anything!");

            Console.Write("Enter beverage's category: ");
            date = Console.ReadLine();

            if (string.IsNullOrEmpty(date)) throw new ArgumentException("You didn't write anything!");

            Console.Write("Enter beverage's price: ");
            price = Convert.ToInt32(Console.ReadLine());

            if (price == 0) throw new ArgumentException("You didn't write anything!");

            Console.Write("Enter beverage's volume: ");
            volume = Convert.ToDouble(Console.ReadLine());

            if (volume == 0) throw new ArgumentException("You didn't write anything!");

            Console.Write("Enter beverage's type: ");
            type = Console.ReadLine();

            if (string.IsNullOrEmpty(type)) throw new ArgumentException("You didn't write anything!");
        }

        public void GetProperPrice()
        {
            if (price > 100)
            {
                Console.WriteLine("{0} costs more than 100, so it has 50% discount! It's final price is {1}.", name, price*0.5);
            }
            else
            {
                Console.WriteLine("{0} costs less than 100, so it's price is default - {1}.", name, price);
            }
        }
    }
    class Task6
    {
        static void Main(string[] args)
        {
            Menu tea = new Menu();
            Menu coffee = new Menu();

            tea.SetUserValues();
            coffee.SetUserValues();

            Console.WriteLine();

            Console.WriteLine(tea.ToString());
            Console.WriteLine(coffee.ToString());

            Console.WriteLine();

            tea.GetProperPrice();
            coffee.GetProperPrice();
        }
    }
}
