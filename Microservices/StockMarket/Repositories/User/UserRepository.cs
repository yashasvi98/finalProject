using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.Models;
using StockMarket.Repositories.User;
namespace StockMarket.Repositories
{
    public class UserRepository : UserLoginInterface
    {
        public StockMarketDBContext SmDb = new StockMarketDBContext();

        public bool check(UserEntity u)
        {
            //decimal id = userEntity.Id;
            UserEntity u1 = SmDb.UserEntity.FirstOrDefault(i => i.Username == u.Username && i.Password == u.Password && i.UserType == u.UserType);
            if (u1 == null)
                return false;
            return true;
        }

        public void create(UserEntity u)
        {
            SmDb.UserEntity.Add(u);
            SmDb.SaveChanges();
        }

        public List<UserEntity> getall()
        {
            return SmDb.UserEntity.Where(x => x.UserType == "User").ToList();
        }
    }
}
