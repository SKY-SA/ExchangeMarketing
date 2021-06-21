using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderProductService 
    {
        List<OrderProduct> GetList();
        void Add(OrderProduct orderProduct);
        void Delete(OrderProduct orderProduct);
        List<OrderProduct> GetList_SuccessedBuy();
        void Add_SuccessedBuy(OrderProduct buyedProduct);
        List<PurchaseHistoryProductDto> GetDetailsOfProduct(List<Category> categories);
    }
}
