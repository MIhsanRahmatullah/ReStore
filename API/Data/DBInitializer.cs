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
                    PictureUrl = "/images/products/xiaomiRedmiNote8.jpg",
                    Brand = "Xiaomi",
                    Type = "SmartPhone",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Xiaomi Redmi Note 7",
                    Description = "Original",
                    Price = 1500000,
                    PictureUrl = "images/products/xiaomiRedmiNote7.jpg",
                    Brand = "Xiaomi",
                    Type = "SmartPhone",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Xiaomi Redmi Note 9",
                    Description = "Original",
                    Price = 1500000,
                    PictureUrl = "images/products/xiaomiRedmiNote9.jpg",
                    Brand = "Xiaomi",
                    Type = "SmartPhone",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Xiaomi Redmi Note 10",
                    Description = "Original",
                    Price = 1500000,
                    PictureUrl = "images/products/xiaomiRedmiNote7.jpg",
                    Brand = "Xiaomi",
                    Type = "SmartPhone",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Xiaomi Redmi Note 11",
                    Description = "Original",
                    Price = 1500000,
                    PictureUrl = "images/products/xiaomiRedmiNote7.jpg",
                    Brand = "Xiaomi",
                    Type = "SmartPhone",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Iphone X",
                    Description = "Original",
                    Price = 8000000,
                    PictureUrl = "images/products/iphoneX.jpg",
                    Brand = "Apple",
                    Type = "SmartPhone",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Iphone XR",
                    Description = "Original",
                    Price = 10000000,
                    PictureUrl = "images/products/iphoneXR.jpg",
                    Brand = "Apple",
                    Type = "SmartPhone",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Iphone XS",
                    Description = "Original",
                    Price = 10000000,
                    PictureUrl = "images/products/iphoneXS.jpg",
                    Brand = "Apple",
                    Type = "SmartPhone",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Iphone 11",
                    Description = "Original",
                    Price = 12000000,
                    PictureUrl = "images/products/iphone11.jpg",
                    Brand = "Apple",
                    Type = "SmartPhone",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Iphone 12",
                    Description = "Original",
                    Price = 14000000,
                    PictureUrl = "images/products/iphone12.jpg",
                    Brand = "Apple",
                    Type = "SmartPhone",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Iphone 13",
                    Description = "Original",
                    Price = 16000000,
                    PictureUrl = "images/products/iphone13.jpg",
                    Brand = "Apple",
                    Type = "SmartPhone",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Oppo A5S",
                    Description = "Original",
                    Price = 3000000,
                    PictureUrl = "images/products/oppoA5S.jpg",
                    Brand = "Oppo",
                    Type = "SmartPhone",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Oppo Reno 5",
                    Description = "Original",
                    Price = 4000000,
                    PictureUrl = "images/products/oppoReno5.jpg",
                    Brand = "Oppo",
                    Type = "SmartPhone",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Vivo V20",
                    Description = "Original",
                    Price = 3000000,
                    PictureUrl = "images/products/vivoV20.jpg",
                    Brand = "Vivo",
                    Type = "SmartPhone",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Vivo Y12",
                    Description = "Original",
                    Price = 2000000,
                    PictureUrl = "images/products/vivoY12.jpg",
                    Brand = "Vivo",
                    Type = "SmartPhone",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Samsung Galaxy A52",
                    Description = "Original",
                    Price = 4000000,
                    PictureUrl = "images/products/samsungGalaxyA52.jpg",
                    Brand = "Samsung",
                    Type = "SmartPhone",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Samsung Galaxy A72",
                    Description = "Original",
                    Price = 6000000,
                    PictureUrl = "images/products/samsungGalaxyA72.jpg",
                    Brand = "Samsung",
                    Type = "SmartPhone",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Samsung Galaxy Fold",
                    Description = "Original",
                    Price = 10000000,
                    PictureUrl = "images/products/samsungGalaxyFold.jpg",
                    Brand = "Samsung",
                    Type = "SmartPhone",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Samsung Galaxy Note 10",
                    Description = "Original",
                    Price = 8000000,
                    PictureUrl = "images/products/samsungGalaxyNote10.jpg",
                    Brand = "Samsung",
                    Type = "SmartPhone",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Cable Type C",
                    Description = "Original",
                    Price = 30000,
                    PictureUrl = "images/products/chargerTypeC.jpg",
                    Brand = "No Brand",
                    Type = "accessories",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Headset",
                    Description = "Original",
                    Price = 20000,
                    PictureUrl = "images/products/headset.jpg",
                    Brand = "No Brand",
                    Type = "accessories",
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