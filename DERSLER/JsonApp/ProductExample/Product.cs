using System;

namespace JsonApp.ProductExample
{
    class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductAmount { get; set; }
        public DateTime ProductAddTime { get; set; }
        public string[] ProductKind { get; set; }
    }
}
