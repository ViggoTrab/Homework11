using System;
using System.Collections.Generic;
using System.Text.Json;

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

                catalog.AddProducts(newProduct1);
                catalog.AddProducts(newProduct2);
                catalog.AddProducts(newProduct3);

                Console.WriteLine("Serialized Products:");

                List<string> serializedProducts = catalog.SerializeJsonDemo();

                string newProduct4 = "[{\"Name\":\"Product4\",\"Price\":60,\"Quantity\":40}]";

                List<string> serializedProducts2 = new List<string> { newProduct4 };

                Console.WriteLine("Deserialized Products:");

                catalog.DeserializeJsonDemo(serializedProducts2);
                
                foreach (var product in catalog.Products)
                {
                    Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}");
                }

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
