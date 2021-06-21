using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IAccountantDal 
    {
        void PayCommissinFee(double commissionFee);
        double ShowBalance();
    }
}
