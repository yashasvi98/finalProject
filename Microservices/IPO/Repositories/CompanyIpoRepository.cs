using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IPO.Models;
namespace IPO.Repositories
{
    public class CompanyIpoRepository : CompanyIPOInterface
    {
        public StockMarketDBContext SmDb = new StockMarketDBContext();

        public CompanyEntity getCompanydetails(decimal Stockcode)
        {
            CompanyEntity i = SmDb.CompanyEntities.FirstOrDefault(i => i.CompanyStockCode == Stockcode);
            return i;
        }

        public IpoDetailEntity getCompanyIPOdetails(decimal Stockcode)
        {
            IpoDetailEntity i = SmDb.IpoDetailEntities.Find(Stockcode);
            return i;
        }
        public decimal getCompanyStockPrice(decimal StockCode, DateTime d1, DateTime d2, TimeSpan t1, TimeSpan t2)
        {
            List<decimal> d;
            d = SmDb.StockPriceEntities.Where(j => j.CompanyStockCode == StockCode && j.Date >= d1 && j.Date <= d2 && j.Time >= t1 && j.Time <= t2).Select(e => e.CurrentPrice).ToList();
            decimal c = d.Average();
            return c;
        }
        public void addCompany(CompanyEntity c)
         {
            SmDb.CompanyEntities.Add(c);
            SmDb.SaveChanges();
        }
        public void updateCompany(CompanyEntity c)
        {
            SmDb.CompanyEntities.Update(c);
            SmDb.SaveChanges();
        }
        public List<CompanyEntity> getallcompanies()
        {
            return SmDb.CompanyEntities.ToList();
        }

        public void addIPO(IpoDetailEntity i)
        {
            SmDb.IpoDetailEntities.Add(i);
            SmDb.SaveChanges();
        }
        public List<IpoDetailEntity> getallIPO()
        {
           return SmDb.IpoDetailEntities.ToList();
        }

        public List<decimal> fromtopricelist(decimal Stockcode, DateTime d1, DateTime d2, TimeSpan t1, TimeSpan t2)
        {
            List<decimal> d;
            d = SmDb.StockPriceEntities.Where(j => j.CompanyStockCode == Stockcode && j.Date >= d1 && j.Date <= d2 && j.Time >= t1 && j.Time <= t2).Select(e => e.CurrentPrice).ToList();
            //decimal c = d.Average();
            return d;
        }
    }
}