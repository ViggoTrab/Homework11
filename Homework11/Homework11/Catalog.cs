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

        public void AddProducts(Product product)
        {
            Products.Add(product);
        }

        public List<string> SerializeJsonDemo()
        {
            List<string> serializedProducts = new List<string>();

            foreach (var product in Products)
            {
                string serializedJson = JsonSerializer.Serialize(product);
                serializedProducts.Add(serializedJson);
            }

            foreach (var serializedProduct in serializedProducts)
            {
                Console.WriteLine(serializedProduct);
            }

            return serializedProducts;
        }

        public void DeserializeJsonDemo(List<string> serializedProducts)
        {
            try
            {
                foreach (var productJson in serializedProducts)
                {
                    List<Product> deserializedProducts = JsonSerializer.Deserialize<List<Product>>(productJson);

                    foreach (var product in deserializedProducts)
                    {
                        AddProducts(product);
                    }
                }
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }
    }
}

