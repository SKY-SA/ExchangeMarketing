using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryAdminDal : IAdminDal
    {
        List<Admin> Admins;
        public InMemoryAdminDal()
        {
            Admins = new List<Admin>
            {
                new Admin {Id = 1,IdentityNumber = "admin",Password = "admin"},
                new Admin {Id = 2,IdentityNumber = "11",Password = "11"}
            };
        }
        public void Add(Admin entity)
        {
            Admins.Add(entity);
        }

        public void Delete(Admin entity)
        {
            Admin adminToDelete = null;
            foreach (var admin in Admins)
            {
                if (admin.Id == entity.Id)
                    adminToDelete = entity;
            }
            Admins.Remove(adminToDelete);
        }
        public List<Admin> GetList()
        {
            return Admins;
        }

        public void Update(Admin entity)
        {
            Admin adminToUpdate = null;
            foreach (var admin in Admins)
            {
                if (admin.Id == entity.Id)
                    adminToUpdate = entity;
            }
            adminToUpdate.IdentityNumber = entity.IdentityNumber;
            adminToUpdate.Password = entity.Password;
        }
    }
}
