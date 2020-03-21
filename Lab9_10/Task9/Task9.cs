using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Warehouse
    {
        public string name;
        public string type;
        public int quantity;
        public int cost;

        public Warehouse()
        {
            this.name = "Default product name";
            this.type = "Other products";
            this.quantity = 1;
            this.cost = 0;
        }

        public Warehouse(string name, string type, int quantity, int cost)
        {
            this.name = name;
            this.type = type;
            this.quantity = quantity;
            this.cost = cost;
        }

        public void SetUserValues()
        {
            Console.Write("Enter product's name: ");
            name = Console.ReadLine();

            if (string.IsNullOrEmpty(name)) throw new ArgumentException("You didn't write anything!");

            Console.Write("Enter product's type: ");
            type = Console.ReadLine();

            if (string.IsNullOrEmpty(type)) throw new ArgumentException("You didn't write anything!");

            Console.Write("Enter product's quantity: ");
            quantity = Convert.ToInt32(Console.ReadLine());

            if (quantity == 0) throw new ArgumentException("You didn't write anything!");

            Console.Write("Enter product's cost: ");
            cost = Convert.ToInt32(Console.ReadLine());

            if (cost == 0) throw new ArgumentException("You didn't write anything!");
        }
    }
    class Task9
    {
        static void Main(string[] args)
        {
            Console.Write("How many products will you set? ");
            int n = Convert.ToInt32(Console.ReadLine());

            List<Warehouse> shop = new List<Warehouse>();

            for (int i = 0; i < n; i++)
            {
                shop.Add(new Warehouse());
                shop[i].SetUserValues();
                Console.WriteLine();
            }

            bool searchIsFinished = false;

            while (!searchIsFinished)
            {
                Console.Write("Search for a product, enter it's name: ");
                string userProductInput = Console.ReadLine();

                var find = shop.FirstOrDefault(x => x.name == userProductInput);
                if (find != null)
                {
                    Console.WriteLine("Product name - {0}, there are {1} units of it. It costs ${2}.", find.name, find.quantity, find.cost);
                } else
                {
                    Console.WriteLine("No matches.");
                }

                Console.Write("\nContinue search? Write N if you want to finish it. ");
                string userAnswer = Console.ReadLine();
                if(userAnswer == "N")
                {
                    searchIsFinished = true;
                }
            }
        }
    }
}
