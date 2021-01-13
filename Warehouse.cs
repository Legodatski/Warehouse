using System;
using System.Linq;
using System.Collections.Generic;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Dictionary<string, Product> products = new Dictionary<string, Product>();

            string[] names = Console.ReadLine().Split(' ').ToArray();

            int[] counts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            double[] prices = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < names.Length; i++)
            {
                Product currentProduct = new Product();

                currentProduct.name = names[i];
                currentProduct.price = prices[i];



                try
                {
                    currentProduct.count = counts[i];
                }
                catch (Exception)
                {
                    currentProduct.count = 1;
                }

                products.Add(names[i], currentProduct);
            }



            while (true)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();

                string name = command[0];

                if (name == "done")
                    return;
                else
                {
                    int count = int.Parse(command[1]);

                    products[name].count -= count;

                    if (products[name].count < 0)
                    {

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("We do not have enough " + name);
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    else
                    {

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{name} x {count} costs {count * products[name].price:F2}");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
        }
    }



    class Product
    {
        public string name { get; set; }

        public int count { get; set; }

        public double price { get; set; }

        public Product()
        {
            name = name;

            count = count;

            price = price;
        }

    }
}