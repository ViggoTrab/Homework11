using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
            string json = JsonConvert.SerializeObject(Products, Formatting.Indented);

            Console.WriteLine("Serialized Products:");
            Console.WriteLine();
            Console.WriteLine(json);
        }

        public void DeserializeJsonDemo(string jsonString)
        {
            var products = JsonConvert.DeserializeObject<List<Product>>(jsonString);

            Products.AddRange(products);

            Console.WriteLine("Deserialized Products:");
            Console.WriteLine();
            foreach (var product in Products)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}");
            }
        }
    }
}

