using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IPO.Models;
namespace IPO.Repositories
{
    interface CompanyIPOInterface
    {
        public IpoDetailEntity getCompanyIPOdetails(decimal Stockcode);
        public CompanyEntity getCompanydetails(decimal Stockcode);

        public decimal getCompanyStockPrice(decimal Stockcode, DateTime d1, DateTime d2, TimeSpan t1, TimeSpan t2);

        public void addCompany(CompanyEntity c);
        public void updateCompany(CompanyEntity c);

        public List<CompanyEntity> getallcompanies();

        public void addIPO(IpoDetailEntity i);

        public List<IpoDetailEntity> getallIPO();

        public List<decimal> fromtopricelist(decimal Stockcode, DateTime d1, DateTime d2, TimeSpan t1, TimeSpan t2);
    }
}
