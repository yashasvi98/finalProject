﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sector.Models;
using Sector.Repositories;
namespace Sector.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectorController : ControllerBase
    {
        public SectorRepository _repo = new SectorRepository();
        [HttpGet]
        [Route("getbysector/{name}")]

        public IActionResult getcompanies(string name)
        {
            List<CompanyEntity> i = _repo.getbysector(name);
            return Ok(i);
        }
        [HttpGet]
        [Route("getsectorprice/{name}")]
        public IActionResult getsectorprice(string name)
        {
            decimal d = _repo.price(name);
            return Ok(d);
        }
        [HttpGet]
        [Route("sectorprice/{sectorname}/{d1}/{d2}/{t1}/{t2}")]
        public IActionResult FromTo(string sectorname, DateTime d1, DateTime d2, TimeSpan t1, TimeSpan t2)
        {
            decimal l = _repo.FromToPrice(sectorname, d1, d2, t1, t2);
            return Ok(l);
        }
        [HttpGet]
        [Route("sectorpricelist/{sectorname}/{d1}/{d2}/{t1}/{t2}")]
        public IActionResult FromToSector(string sectorname, DateTime d1, DateTime d2, TimeSpan t1, TimeSpan t2)
        {
            List<decimal> l = _repo.FromToPriceSector(sectorname, d1, d2, t1, t2);
            return Ok(l);
        }
    }
}
