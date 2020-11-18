using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sector.Models;
namespace Sector.Repositories
{
    interface SectorInterface
    {
        public List<CompanyEntity> getbysector(string Sname);

        public decimal price(string Sname);

        public decimal FromToPrice(String sectorname, DateTime d1, DateTime d2, TimeSpan t1, TimeSpan t2);

        public List<decimal> FromToPriceSector(String sectorname, DateTime d1, DateTime d2, TimeSpan t1, TimeSpan t2);
    }
}
