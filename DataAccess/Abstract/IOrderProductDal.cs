using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IOrderProductDal 
    {
        List<OrderProduct> GetList();
        List<OrderProduct> GetList_SuccessedBuy();
        void Add_SuccessedBuy(OrderProduct buyedProduct);
        void Add(OrderProduct orderProduct);
        void Delete(OrderProduct orderProduct);
        List<PurchaseHistoryProductDto> GetDetailsOfProduct(List<Category> categories);
    }
}
