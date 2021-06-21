using Business.Abstract;
using Business.Constants;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal userDal;
        public UserManager(IUserDal userDal)
        {
            this.userDal = userDal;
            
        }
        public void Add(User user)
        {
            this.userDal.Add(user);
        }

        public void Delete(User user)
        {
            this.userDal.Delete(user);
        }

        public List<User> GetList()
        {
            return this.userDal.GetList();
        }

        public void Update(User user)
        {
            this.userDal.Update(user);
        }
    }
}
