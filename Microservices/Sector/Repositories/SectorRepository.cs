using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sector.Models;
namespace Sector.Repositories
{
    public class SectorRepository : SectorInterface
    {
        public StockMarketDBContext SmDb = new StockMarketDBContext();

        public decimal FromToPrice(String sectorname, DateTime d1, DateTime d2, TimeSpan t1, TimeSpan t2)
        {
            decimal d = 0;
            List<decimal> l = SmDb.CompanyEntities.Where(i => i.Sector == sectorname).Select(e => e.CompanyStockCode).ToList();
            for (int i = 0; i < l.Count(); i++)
                d = d + SmDb.StockPriceEntities.Where(j => j.CompanyStockCode == l[i] && j.Date >= d1 && j.Date <= d2 && j.Time >= t1 && j.Time <= t2).Select(e => e.CurrentPrice).FirstOrDefault();
            return d / l.Count;
        }
        public List<CompanyEntity> getbysector(string Sname)
        {
            List<CompanyEntity> l = SmDb.CompanyEntities.Where(i => i.Sector == Sname).ToList();
            return l;
        }
        public decimal price(string Sname)
        {
            decimal d = 0;
            List<decimal> l = SmDb.CompanyEntities.Where(i => i.Sector == Sname).Select(e => e.CompanyStockCode).ToList();
            for (int i = 0; i < l.Count(); i++)
                d = d + SmDb.StockPriceEntities.Where(j => j.CompanyStockCode == l[i]).Select(e => e.CurrentPrice).FirstOrDefault();
            return d / l.Count;
        }
        public List<decimal> FromToPriceSector(String sectorname, DateTime d1, DateTime d2, TimeSpan t1, TimeSpan t2)
        {

            List<decimal> l = SmDb.CompanyEntities.Where(i => i.Sector == sectorname).Select(e => e.CompanyStockCode).ToList();
            List<decimal> d = new List<decimal>();
            for (int i = 0; i < l.Count(); i++)
                d.Add(SmDb.StockPriceEntities.Where(j => j.CompanyStockCode == l[i] && j.Date >= d1 && j.Date <= d2 && j.Time >= t1 && j.Time <= t2).Select(e => e.CurrentPrice).FirstOrDefault());

            return d;

        }
    }
}