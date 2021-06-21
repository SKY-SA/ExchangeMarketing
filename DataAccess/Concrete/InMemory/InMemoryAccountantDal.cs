using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryAccountantDal : IAccountantDal
    {
        Accountant accountant = new Accountant { CommissionAccount = 0};
        public InMemoryAccountantDal()
        {
            accountant.CommissionAccount = 0;
        }


        public void PayCommissinFee(double commissionFee)
        {
            accountant.CommissionAccount += commissionFee;
        }

        public double ShowBalance()
        {
            return accountant.CommissionAccount;
        }
    }
}
