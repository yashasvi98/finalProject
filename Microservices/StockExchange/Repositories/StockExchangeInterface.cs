﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockExchange.Models;
namespace StockExchange.Repositories
{
    public interface StockExchangeInterface
    {
        public void addStockExchange(StockExchangeEntity s);

        public List<StockExchangeEntity> getall();

        public List<CompanyEntity> getcompanies(string Sname);


    }
}
