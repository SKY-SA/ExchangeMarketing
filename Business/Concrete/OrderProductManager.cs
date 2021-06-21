using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderProductManager : IOrderProductService
    {
        IOrderProductDal _orderProductDal;

        public OrderProductManager(IOrderProductDal orderProductDal)
        {
            _orderProductDal = orderProductDal;
        }

        public void Add(OrderProduct orderProduct)
        {
            _orderProductDal.Add(orderProduct);
        }

        public void Add_SuccessedBuy(OrderProduct buyedProduct)
        {
            _orderProductDal.Add_SuccessedBuy(buyedProduct);
        }

        public void Delete(OrderProduct orderProduct)
        {
            _orderProductDal.Delete(orderProduct);
        }

        public List<PurchaseHistoryProductDto> GetDetailsOfProduct(List<Category> categories)
        {
            return _orderProductDal.GetDetailsOfProduct(categories);
        }

        public List<OrderProduct> GetList()
        {
            return _orderProductDal.GetList();
        }

        public List<OrderProduct> GetList_SuccessedBuy()
        {
            return _orderProductDal.GetList_SuccessedBuy();
        }
    }
}
