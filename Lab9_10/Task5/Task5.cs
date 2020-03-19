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

        public void GetProperPrice()
        {
            if (price >= 78 && price <= 100)
            {
                Console.WriteLine("{0} is in range of 78 to 100, it's price - {1}",name,price);
            } else
            {
                Console.WriteLine("{0} is beyond the range of 78 to 100, it's price - {1}",name,price);
            }
        }

        public void WriteToFile()
        {
            string priceInfo;
            string description = "Dish's name: " + name + ", category: " + category + ", price: " + price + ", weight: " + weight + ", type: " + weight;

            if (price >= 78 && price <= 100)
            { 
                priceInfo = name+" is in range of 78 to 100, it's price - "+price;
            }
            else
            {
                priceInfo = name+" is beyond the range of 78 to 100, it's price - "+price;
            }
            string info = priceInfo + "\n" + description;
            File.AppendAllText("C:\\users\\admin\\documents\\task5.txt", info);

            Console.WriteLine("Information was succesfully written to the file!");
        }
    }
    class Task5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter cake's name: ");
            string cakeName = Console.ReadLine();

            Console.Write("Enter cake's category: ");
            string cakeCategory = Console.ReadLine();

            Console.Write("Enter cake's price: ");
            int cakePrice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter cake's weight: ");
            int cakeWeight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter cake's type: ");
            string cakeType = Console.ReadLine();

            Console.Write("Enter cupcake's name: ");
            string cupcakeName = Console.ReadLine();

            Console.Write("Enter cupcake's category: ");
            string cupcakeCategory = Console.ReadLine();

            Console.Write("Enter cupcake's price: ");
            int cupcakePrice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter cupcake's weight: ");
            int cupcakeWeight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter cake's type: ");
            string cupcakeType = Console.ReadLine();

            Menu cake = new Menu();
            cake.name = cakeName;
            cake.category = cakeCategory;
            cake.price = cakePrice;
            cake.weight = cakeWeight;
            cake.type = cakeType;

            Menu cupcake = new Menu();
            cupcake.name = cupcakeName;
            cupcake.category = cupcakeCategory;
            cupcake.price = cupcakePrice;
            cupcake.weight = cupcakeWeight;
            cupcake.type = cupcakeType;
            
            Console.WriteLine("\n"+cake.ToString());
            Console.WriteLine(cupcake.ToString());

            Console.WriteLine();

            cake.GetProperPrice();
            cupcake.GetProperPrice();

            cake.WriteToFile();
            cupcake.WriteToFile();

        }
    }
}
