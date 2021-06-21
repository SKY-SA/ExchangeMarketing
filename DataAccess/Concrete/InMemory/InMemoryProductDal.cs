using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> Products;
        public InMemoryProductDal()
        {
            Products = new List<Product>
            {
                new Product{IsForSale = true,UserId =1, ProductId=1,  CategoryId = 1, ProductName ="64Gb",  UnitPrice = 12000, UnitsInStock = 2, StockType = "Adet", Approve = true},
                new Product{IsForSale = true,UserId =1, ProductId=2,  CategoryId= 1 , ProductName ="128Gb", UnitPrice = 14000, UnitsInStock = 3, StockType = "Adet", Approve = true},
                new Product{IsForSale = true,UserId =1, ProductId=3,  CategoryId= 2 , ProductName ="128Gb", UnitPrice = 13000, UnitsInStock = 4, StockType = "Adet", Approve = true},
                new Product{IsForSale = true,UserId =1, ProductId=4,  CategoryId= 3 , ProductName ="128Gb", UnitPrice = 10000, UnitsInStock = 1, StockType = "Adet", Approve = true},
                new Product{IsForSale = true,UserId =1, ProductId=5,  CategoryId= 3 , ProductName ="256Gb", UnitPrice = 11500, UnitsInStock = 8, StockType = "Adet", Approve = true},
                new Product{IsForSale = true,UserId =1, ProductId=11, CategoryId= 4 , ProductName ="256Gb", UnitPrice = 16900, UnitsInStock = 2, StockType = "Adet", Approve = true},
                new Product{IsForSale = true,UserId =1, ProductId=20, CategoryId= 4 , ProductName ="256Gb", UnitPrice = 17400, UnitsInStock = 2, StockType = "Adet", Approve = false},

                new Product{IsForSale = true,UserId =2, ProductId=12, CategoryId= 1, ProductName ="64Gb",  UnitPrice = 11900, UnitsInStock = 2, StockType = "Adet", Approve = true},
                new Product{IsForSale = true,UserId =2, ProductId=6,  CategoryId= 2, ProductName ="128Gb", UnitPrice = 13500, UnitsInStock = 4, StockType = "Adet", Approve = true},
                new Product{IsForSale = true,UserId =2, ProductId=7,  CategoryId= 2, ProductName ="256Gb", UnitPrice = 16000, UnitsInStock = 6, StockType = "Adet", Approve = true},
                new Product{IsForSale = true,UserId =2, ProductId=8,  CategoryId= 3, ProductName ="128Gb", UnitPrice = 10000, UnitsInStock = 1, StockType = "Adet", Approve = true},
                new Product{IsForSale = true,UserId =2, ProductId=9,  CategoryId= 4, ProductName ="128Gb", UnitPrice = 14250, UnitsInStock = 7, StockType = "Adet", Approve = true},
                new Product{IsForSale = true,UserId =2, ProductId=10, CategoryId= 4, ProductName ="256Gb", UnitPrice = 17000, UnitsInStock = 2, StockType = "Adet", Approve = true},
                new Product{IsForSale = true,UserId =2, ProductId=19, CategoryId= 4, ProductName ="256Gb", UnitPrice = 16800, UnitsInStock = 2, StockType = "Adet", Approve = false},

                new Product{IsForSale = true, UserId =4, ProductId=13,   CategoryId= 1, ProductName ="64Gb",   UnitPrice = 12000,  UnitsInStock = 2, StockType = "Adet", Approve = true},
                new Product{IsForSale = true,UserId =4,  ProductId=14,   CategoryId= 1, ProductName ="128Gb",  UnitPrice = 14000,  UnitsInStock = 3, StockType = "Adet", Approve = true},
                new Product{IsForSale = true,UserId =4,  ProductId=15,   CategoryId= 2, ProductName ="128Gb",  UnitPrice = 13000,  UnitsInStock = 4, StockType = "Adet", Approve = true},
                new Product{IsForSale = true,UserId =4,  ProductId=16,   CategoryId= 3, ProductName ="128Gb",  UnitPrice = 10000,  UnitsInStock = 1, StockType = "Adet", Approve = true},
                new Product{IsForSale = true,UserId =4,  ProductId=17,   CategoryId= 3, ProductName ="256Gb",  UnitPrice = 11500,  UnitsInStock = 8, StockType = "Adet", Approve = true},
                new Product{IsForSale = true,UserId =4,  ProductId=11,   CategoryId= 4, ProductName ="256Gb",  UnitPrice = 16900,  UnitsInStock = 2, StockType = "Adet", Approve = true},
                new Product{IsForSale = true,UserId =4,  ProductId=21,   CategoryId= 4, ProductName ="256Gb",  UnitPrice = 17700,  UnitsInStock = 2, StockType = "Adet", Approve = false}
            };
        }
        public void Add(Product entity)
        {
            Random rnd = new Random();
            entity.ProductId = rnd.Next(20, 10000);
           
            Products.Add(entity);
        }

        public void Delete(Product entity)
        {
            Product productToDelete = null;
            foreach (var product in Products)
            {
                if (product.ProductId == entity.ProductId)
                    productToDelete = entity;
            }
            Products.Remove(productToDelete);
        }

        public List<Product> GetList()
        {
            return Products;
        }

        public void Update(Product entity)
        {
            Product productsToUpdate = null;
            foreach (var product in Products)
            {
                if (product.ProductId == entity.ProductId)
                    productsToUpdate = entity;
            }
            productsToUpdate.ProductName = entity.ProductName;
            productsToUpdate.UserId = entity.UserId;
            productsToUpdate.UnitPrice = entity.UnitPrice;
            productsToUpdate.UnitsInStock = entity.UnitsInStock;
        }
        
        public void BuyProduct(Product product, User user)
        {
            foreach (var p in GetList())
            {
                if(p.ProductId == product.ProductId)
                {
                    p.UserId = user.UserId;
                    p.Approve = false;
                }
            }
        }

        public List<ProductDto> GetDetailsByCategoryId(List<Category> categories)
        {
            var result = from p in Products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         select new ProductDto { UserId = p.UserId, ProductId = p.ProductId, CategoryId = p.CategoryId, CategoryName = c.CategoryName, ProductName = p.ProductName,
                             UnitPrice = p.UnitPrice, UnitsInStock = p.UnitsInStock, Approve = p.Approve, IsForSale = p.IsForSale, StockType = p.StockType
                         };


            return result.ToList();
        }
    }
}
