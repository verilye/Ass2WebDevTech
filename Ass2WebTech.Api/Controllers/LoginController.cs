using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ass2WebTech.Services;
using Ass2WebTech.Models;
using Ass2WebTech.Core.Services;
using Newtonsoft.Json;

namespace Ass2WebTech.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly IUserService _userService;
        

        public LoginController(IUserService userService)
        {
            _userService = userService;
        }


        public class PostReq
        {
            public string username {get;set;}
            public string password {get;set;}
        }

        [HttpPost]
        public async Task<ActionResult<Login>> SignIn(PostReq req)
        {
            
            var result = await _userService.Login(req.username,req.password);

            return result;
            
        }


        [HttpGet]
        [Route("preload")]
        public async Task<string> Preload()
        {

            await _userService.Preload();
            return "Preloaded data";
        }

    }
}