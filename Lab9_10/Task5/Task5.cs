using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task5
{
    class Menu
    {
        public string name { set; get; }
        public string category { set; get; }
        public int price { set; get; }
        public int weight { set; get; }
        public string type { set; get; }

        public override string ToString()
        {
            return String.Format("Dish's name: {0}, category: {1}, price: {2}, weight: {3}, type: {4}", name, category, price, weight, type);
        }

        public void SetUserValues()
        {
            Console.Write("Enter dish's name: ");
            name = Console.ReadLine();

            if (string.IsNullOrEmpty(name)) throw new ArgumentException("You didn't write anything!");

            Console.Write("Enter dish's category: ");
            category = Console.ReadLine();

            if (string.IsNullOrEmpty(category)) throw new ArgumentException("You didn't write anything!");

            Console.Write("Enter dish's price: ");
            price = Convert.ToInt32(Console.ReadLine());

            if (price == 0) throw new ArgumentException("You didn't write anything!");

            Console.Write("Enter dish's weight: ");
            weight = Convert.ToInt32(Console.ReadLine());

            if (weight == 0) throw new ArgumentException("You didn't write anything!");

            Console.Write("Enter dish's type: ");
            type = Console.ReadLine();

            if (string.IsNullOrEmpty(type)) throw new ArgumentException("You didn't write anything!");
        }

        public void GetProperPrice()
        {
            if (price >= 78 && price <= 100)
            {
                Console.WriteLine("{0} is in range of 78 to 100, it's price - {1}",name,price);
            }
        }

        public void WriteToFile()
        {
            string description = "Dish's name: " + name + ", \ncategory: " + category + ", \nprice: " + price + ", \nweight: " + weight + ", \ntype: " + weight+"\n\n";

            File.AppendAllText("C:\\users\\admin\\documents\\task5.txt", description);

            Console.WriteLine("Information was succesfully written to the file!");
        }
    }
    class Task5
    {
        static void Main(string[] args)
        {
            Menu cake = new Menu();
            cake.SetUserValues();

            Menu cupcake = new Menu();
            cupcake.SetUserValues();
            
            Console.WriteLine("\n"+cake.ToString());
            Console.WriteLine(cupcake.ToString());

            Console.WriteLine();

            cake.GetProperPrice();
            cupcake.GetProperPrice();

            Console.WriteLine();

            cake.WriteToFile();
            cupcake.WriteToFile();

        }
    }
}
