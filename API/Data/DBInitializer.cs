using System.Collections.Generic;
using System.Linq;
using API.Entities;

namespace API.Data
{
    public static class DBInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;

            var Products = new List<Product>
            {
                new Product
                {
                    Name = "Xiaomi Redmi Note 8",
                    Description = "Original",
                    Price = 2000000,
                    PictureUrl = "/",
                    Brand = "Xiaomi",
                    Type = "SmartPhone",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Xiaomi Redmi Note 7",
                    Description = "Original",
                    Price = 1500000,
                    PictureUrl = "/",
                    Brand = "Xiaomi",
                    Type = "SmartPhone",
                    QuantityInStock = 100
                },
            };
            foreach (var product in Products)
            {
                context.Products.Add(product);
            }
            context.SaveChanges();
        }
    }
}