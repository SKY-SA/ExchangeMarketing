using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            this.adminDal = adminDal;
        }

        public void Add(Admin admin)
        {
            this.adminDal.Add(admin);
        }

        public void Delete(Admin admin)
        {
            this.adminDal.Delete(admin);
        }

        public List<Admin> GetList()
        {
            return this.adminDal.GetList();
        }

        public void Update(Admin admin)
        {
            this.adminDal.Update(admin);
        }
    }
}
