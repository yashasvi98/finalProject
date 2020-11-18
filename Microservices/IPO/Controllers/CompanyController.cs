using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IPO.Models;
using IPO.Repositories;
namespace IPO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        public CompanyIpoRepository _repo = new CompanyIpoRepository();
        [HttpGet]
        [Route("getIPO/{Stockcode}")]
        public IActionResult getIPOdetails(decimal Stockcode)
        {
            IpoDetailEntity l = _repo.getCompanyIPOdetails(Stockcode);
            return Ok(l);
        }
        [HttpGet]
        [Route("getCompany/{Stockcode}")]
        public IActionResult getCompany(decimal Stockcode)
        {
            CompanyEntity l = _repo.getCompanydetails(Stockcode);
            return Ok(l);
        }
        [HttpGet]
        [Route("getallCompanies")]
        public IActionResult getallCompanies()
        {
            List<CompanyEntity> l = _repo.getallcompanies();
            return Ok(l);
        }
        [HttpGet]
        [Route("getallIPO")]
        public IActionResult getallIPO()
        {
            List<IpoDetailEntity> l = _repo.getallIPO();
            return Ok(l);
        }
        [HttpGet]
        [Route("getCompanyPrice/{Stockcode}/{d1}/{d2}/{t1}/{t2}")]
        public IActionResult getCompanyPrice(decimal StockCode, DateTime d1, DateTime d2, TimeSpan t1, TimeSpan t2)
        {
            decimal d = _repo.getCompanyStockPrice(StockCode, d1,  d2,  t1,  t2);
            return Ok(d);
        }
        [HttpGet]
        [Route("getchart/{Stockcode}/{d1}/{d2}/{t1}/{t2}")]
        public IActionResult getCompanyPriceList(decimal StockCode, DateTime d1, DateTime d2, TimeSpan t1, TimeSpan t2)
        {
            List<decimal> d = _repo.fromtopricelist(StockCode, d1, d2, t1, t2);
            return Ok(d);
        }

        [HttpPost]
        [Route("addcompany")]
        public IActionResult addcompany(CompanyEntity c)
        {
            _repo.addCompany(c);
            return Ok("Company Added");
        }

        [HttpPut]
        [Route("updatecompany")]
        public IActionResult updatecompany(CompanyEntity c)
        {
            _repo.updateCompany(c);
            return Ok("Company Updated");
        }

        [HttpPost]
        [Route("addIPO")]
        public IActionResult addIPO(IpoDetailEntity i)
        {
            _repo.addIPO(i);
            return Ok("IPO Added");
        }
    }
}
