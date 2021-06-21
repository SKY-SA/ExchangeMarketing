using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class OrderProduct : Product
    {
        public int ReceiverUserId { get; set; }
        public double DemandQuantity { get; set; }
        public double DemandPrice { get; set; }
        public double TotalPaybleAmount { get; set; }
        public DateTime Time { get; set; }
    }
}
