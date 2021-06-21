using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryOrderProdutDal : IOrderProductDal
    {
        List<OrderProduct> orderProducts;
        List<OrderProduct> buyedProducts;
        
        public InMemoryOrderProdutDal()
        {
            orderProducts = new List<OrderProduct>()
            {

            };
            buyedProducts = new List<OrderProduct>()
            { };
        }
        public void Add(OrderProduct orderProduct)
        {
            orderProducts.Add(orderProduct);
        }

        public void Add_SuccessedBuy(OrderProduct buyedProduct)
        {
            buyedProducts.Add(buyedProduct);
        }

        public void Delete(OrderProduct orderProduct)
        {
            OrderProduct orderProductToDelete = null;
            foreach (var p in orderProducts)
            {
                if (p.ProductId == orderProduct.ProductId)
                    orderProductToDelete = p;
            }
            orderProducts.Remove(orderProductToDelete);
        }

        public List<PurchaseHistoryProductDto> GetDetailsOfProduct(List<Category> categories)
        {
            var result = from o in buyedProducts
                         join c in categories
                         on o.CategoryId equals c.CategoryId
                         select new PurchaseHistoryProductDto {CategoryName = c.CategoryName,ProductName = o.ProductName,DemandPrice = o.DemandPrice,DemandQuantity = o.DemandQuantity,
                             ProductId = o.ProductId,StockType = o.StockType,Time = o.Time,TotalPaybleAmount= o.TotalPaybleAmount = o.TotalPaybleAmount,UnitPrice = o.UnitPrice,
                             UnitsInStock = o.UnitsInStock,UserId = o.UserId,ReceiverId=o.ReceiverUserId};

            return result.ToList();
        }

        public List<OrderProduct> GetList()
        {
            return orderProducts;
        }

        public List<OrderProduct> GetList_SuccessedBuy()
        {
            return buyedProducts;
        }
    }
}
