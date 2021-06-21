using Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AccountantManager : IAccountantService
    {
        IAccountantDal _accountantDal;

        public AccountantManager(IAccountantDal accountantDal)
        {
            _accountantDal = accountantDal;
        }

        public void PayCommissinFee(double commissionPee)
        {
            _accountantDal.PayCommissinFee(commissionPee);
        }

        public double ShowBalance()
        {
            return _accountantDal.ShowBalance();
        }
    }
}
