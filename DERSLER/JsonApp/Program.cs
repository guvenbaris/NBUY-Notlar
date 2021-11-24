using System;
using System.Text.Json.Serialization;
using System.Threading.Channels;
using Newtonsoft.Json;

namespace JsonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nesne to Json 
            Product product = new Product
            {
                Id = 1,
                ProductAddTime = new DateTime(1993, 05, 24),
                ProductAmount = 50,
                ProductName = "Mouse",
                ProductPrice = 1200.0d,
                ProductSizes = new string[] { "small", "medium" }
                
            };

            string json = JsonConvert.SerializeObject(product, Formatting.Indented);

            Console.WriteLine(json);

            //Json to Nesne
            string myJson = @"{'Id':1,
                            'ProductAddTime':'1995-4-17T00:00:00',
                            'ProductAmount':'50',
                            'ProductName':'Klavye',
                            'ProductPrice':1200,
                            'ProductSizes':['Small','Medium']}";

            Product product1 = JsonConvert.DeserializeObject<Product>(myJson);

            Console.WriteLine(product1.ProductName);
            Console.WriteLine($"Ürün eklenme zamanı : {product1.ProductAddTime},Ürün fiyatı : {product1.ProductPrice}, Ürün Bedenleri : {product1.ProductSizes[0]}");

        }
    }
}
