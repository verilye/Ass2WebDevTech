using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ass2WebTech.Services;
using Ass2WebTech.Models;
using Ass2WebTech.Core.Services;
using System.Text.Json;
using Newtonsoft.Json;

namespace Ass2WebTech.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IUserService _userService;
        

        public HomeController(IUserService userService)
        {
            _userService = userService;
        }


        public class PostReq
        {
            public string id {get;set;}
        
        }


        [HttpPost]
        public async Task<IEnumerable<Account>> ShowAccounts(PostReq req)
        {

            int a = Int32.Parse(req.id);

            Console.WriteLine(a);
            
            var result = await _userService.DisplayAccounts(a);

            var json = JsonConvert.SerializeObject(result);
                
            Console.WriteLine(json);

            return result;
            
        }

    }
}