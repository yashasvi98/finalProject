using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockExchange.Models;
using StockExchange.Repositories;
namespace StockExchange.Repositories
{
    public class StockExchangeRepository : StockExchangeInterface
    {
        public StockMarketDBContext SmDb = new StockMarketDBContext();
        public void addStockExchange(StockExchangeEntity s)
        {
            SmDb.StockExchangeEntity.Add(s);
            SmDb.SaveChanges();
        }
        public List<StockExchangeEntity> getall()
        {
            return SmDb.StockExchangeEntity.ToList();
        }

        public List<CompanyEntity> getcompanies(string Sname)
        {
            var Sid = SmDb.StockExchangeEntity.Where(i => i.StockExchange == Sname).Select(j => j.SeId).FirstOrDefault();
            List<CompanyEntity> l = SmDb.CompanyEntity.Where(x => x.ListedinStockExchange == Sid).ToList();
            return l;
        }
    }
}
