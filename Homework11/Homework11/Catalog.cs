using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Homework11
{
    public class Catalog
    {
        public List<Product> Products { get; set; }

        public Catalog()
        {
            Products = new List<Product>();
        }

        public void AddProduct(List<Product> products)
        {
            foreach (var product in products)
            {
                Products.Add(product);
            }
        }

        public void SerializeJsonDemo()
        {
            string serializedJson = JsonSerializer.Serialize(Products);

            Console.WriteLine("Serialized Products.");
            Console.WriteLine();
            Console.WriteLine(serializedJson);
        }

        public void DeserializeJsonDemo()
        {
            try
            {
                string newProductJson = "[{\"Name\":\"Product4\",\"Price\":60,\"Quantity\":40}]";

                List<Product> deserializedJson = JsonSerializer.Deserialize<List<Product>>(newProductJson);

                Console.WriteLine("Deserialized Products.");
                Console.WriteLine();
                foreach (var product in Products)
                {
                    Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}");
                }

                foreach (var product in deserializedJson)
                {
                    Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}");
                }

            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }
    }
}

