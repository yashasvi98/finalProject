using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockExchange.Repositories;
using StockExchange.Models;
namespace StockExchange.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockExchangeController : ControllerBase
    {
        public StockExchangeRepository _repo = new StockExchangeRepository();
        [HttpGet]
        [Route("getall")]
        public IActionResult GetAll()
        {
            List<StockExchangeEntity> l = _repo.getall();
            return Ok(l);
        }

        [HttpPost]
        [Route("add")]
        public IActionResult AddSE(StockExchangeEntity s)
        {
            _repo.addStockExchange(s);
            return Ok("Stock Exchange added");
        }

        [HttpGet]
        [Route("getcompanies/{name}")]

        public IActionResult getcompanies(string name)
        {
            List<CompanyEntity> i = _repo.getcompanies(name);
            return Ok(i);
        }
    }
}
