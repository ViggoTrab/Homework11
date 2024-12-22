using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Homework11
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Catalog catalog = new Catalog();

                Product newProduct1 = new Product("Product1", 15, 10);
                Product newProduct2 = new Product("Product2", 30, 20);
                Product newProduct3 = new Product("Product3", 45, 30);

                List<Product> newProducts = new List<Product> { newProduct1, newProduct2, newProduct3 };
                catalog.AddProduct(newProducts);

                catalog.SerializeJsonDemo();
                Console.WriteLine();

                string newProductJson = "[{\"Name\":\"Product4\",\"Price\":60,\"Quantity\":40}]";

                catalog.DeserializeJsonDemo(newProductJson);
            }
            catch (InvalidPriceException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
