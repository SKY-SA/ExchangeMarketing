using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    // Varlık sınıfı
    public class User : IEntity
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
        public string Password { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public double Balance { get; set; }
        public string AddedBalanceType { get; set; }
        public double AddBalance { get; set; }
        public bool BalanceApprove { get; set; }
        public bool IsSeller { get; set; }
        public bool IsReceiver { get; set; }
        public double DemandQuantity { get; set; }
    }
}
