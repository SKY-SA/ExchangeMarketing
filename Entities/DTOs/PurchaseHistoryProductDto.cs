using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class PurchaseHistoryProductDto
    {
        public int ProductId { get; set; }
      
        public string CategoryName { get; set; }
        public int UserId { get; set; }
        public int ReceiverId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public double UnitsInStock { get; set; }
        public string StockType { get; set; }
        public double DemandQuantity { get; set; }
        public double DemandPrice { get; set; }
        public double TotalPaybleAmount { get; set; }
        public DateTime Time { get; set; }
    }
}
