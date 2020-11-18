using System;
using System.Collections.Generic;

namespace StockMarket.Models
{
    public partial class StockPriceEntity
    {
        public StockPriceEntity()
        {
            CompanyEntity = new HashSet<CompanyEntity>();
        }

        public string StockExchange { get; set; }
        public decimal CurrentPrice { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public decimal CompanyStockCode { get; set; }

        public virtual ICollection<CompanyEntity> CompanyEntity { get; set; }
    }
}
