﻿using System;
using System.Collections.Generic;

namespace ThucHanh
{
    class Program
    {
        private static List<Product> listProducts = new List<Product>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("===========================");
                Console.WriteLine("1. Add product");
                Console.WriteLine("2. Display product records");
                Console.WriteLine("3. Delete product by Id");
                Console.WriteLine("4. Exit");
                var choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        Display();
                        break;
                    case 3:
                        Delete();
                        break;
                    case 4:
                        Environment.Exit(1);
                        break;
                }
            }
        }

        public static void Add()
        {
            Console.WriteLine("==============================");
            Console.Write("Please enter the product Id: ");
            var productId = Console.ReadLine();
            Console.Write("Please enter the product Name:");
            var productName = Console.ReadLine();
            Console.Write("Please enter the product Price:");
            var productPrice = Double.Parse(Console.ReadLine());
            Product product = new Product(productName, productId, productPrice);
            listProducts.Add(product);
            Console.WriteLine("Product added !!");
        }

        public static void Display()
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine("{0,-20} {1,-15} {2,-5}", "Product ID", "Product Name", "Price");
            if (listProducts.Count > 0)
            {
                foreach (var product in listProducts)
                {
                    Console.WriteLine("{0,-20} {1,-15} {2,-5}", product.ProductId, product.ProductName,
                        "$" + product.Price);
                }
            }
            else
            {
                Console.WriteLine("No product added !!");
            }
        }

        public static void Delete()
        {
            Console.WriteLine("============================================");
            Console.Write("Please enter the product Id to delete: ");
            var idDelete = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < listProducts.Count; i++)
            {
                if (listProducts[i].ProductId == idDelete)
                {
                    listProducts.RemoveAt(i);
                    Console.WriteLine("Delete Success");
                    break;
                }
                count++;
            }

            if (count == listProducts.Count)
            {
                Console.WriteLine("There is no product id : " + idDelete);
            }
            

            
        }
    }
}