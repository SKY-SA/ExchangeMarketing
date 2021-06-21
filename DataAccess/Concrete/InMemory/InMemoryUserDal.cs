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
    public class InMemoryUserDal : IUserDal
    {
        List<User> Users;

        public InMemoryUserDal()
        {
            Users = new List<User>()
            {
                
                new User{IsReceiver = false,IsSeller = true,UserId =1,UserName = "sky",FirstName = "Kemal",LastName = "Yoğurt",IdentityNumber = "38620461864",Password = "123",PhoneNumber ="5532860343 ",Adress = "Konya",Balance = 100,Email = "onthsky@gmail.com",BalanceApprove = true},
                new User{IsReceiver = false,IsSeller = false,UserId =2,UserName = "samo",FirstName = "Samet",LastName = "Ataş",IdentityNumber = "10076859174",Password = "1234",PhoneNumber = "5442154372",Adress = "Van",Balance = 150,Email = "samet65@gmail.com",BalanceApprove = true},
                new User{IsReceiver = true,IsSeller = false,UserId =3,UserName = "emo",FirstName = "Emre",LastName = "Öztürk",IdentityNumber = "12076846174",Password = "123",PhoneNumber = "5342102572",Adress = "Kocaeli",Balance = 100000,Email = "by_oztrk@gmail.com",BalanceApprove = true},
                new User{IsReceiver = false,IsSeller = false,UserId =4,UserName = "memo",FirstName = "Mehmet",LastName = "Demir",IdentityNumber = "14576847894",Password = "123",PhoneNumber = "5321862572",Adress = "Maraş",Balance = 0,Email = "demir@gmail.com",BalanceApprove = true}
            };
        }

        public void Add(User entity)
        {
            Random rnd = new Random();
            entity.UserId = rnd.Next(10, 1000);
            Users.Add(entity);
        }

        public void Delete(User entity)
        {
            User userToDelete = null;
            foreach (var user in Users)
            {
                if (user.UserId == entity.UserId)
                    userToDelete = entity;
            }
            Users.Remove(userToDelete);
        }

        public List<User> GetList()
        {
            return Users;
        }

        public void Update(User entity)
        {
            User userToUpdate = null;
            foreach (var user in Users)
            {
                if (user.UserId == entity.UserId)
                    userToUpdate = entity;
            }
            userToUpdate.FirstName = entity.FirstName;
            userToUpdate.LastName = entity.LastName;
            userToUpdate.Password = entity.Password;
            userToUpdate.Adress = entity.Adress;
            userToUpdate.Email = entity.Email;
        }
    }
}
