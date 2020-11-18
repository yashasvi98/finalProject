using StockMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.Repositories.Admin;
namespace StockMarket.Repositories
{
    public class AdminRepository : AdminLoginInterface
    {
        public StockMarketDBContext SmDb = new StockMarketDBContext();

        public bool check(UserEntity u)
        {
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
            return SmDb.UserEntity.Where(x => x.UserType == "Admin").ToList();
        }

    }
}
