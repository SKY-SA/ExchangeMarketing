using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    // Varlık sınıfı
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public double UnitsInStock { get; set; }
        public string StockType { get; set; }
        public bool Approve { get; set; }
        public bool IsForSale { get; set; }
    }
}
