using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockMarket.Repositories;
using StockMarket.Models;
namespace StockMarket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserRepository _repo = new UserRepository();

        [HttpPost]
        [Route("add")]
        public IActionResult Usercreate(UserEntity user)
        {
            if (user.UserType == "User")
                _repo.create(user);
            return Ok("User Added");
        }

        [HttpPost]
        [Route("check")]
        public IActionResult Usercheck(UserEntity user)
        {
            bool ans = _repo.check(user);
            if (ans == true)
                return Ok("User logged in");
            return Ok("No Access");
        }
        [HttpGet]
        [Route("getall")]
        public IActionResult Getall()
        {
            List<UserEntity> l = _repo.getall();
            return Ok(l);
        }
    }
}
