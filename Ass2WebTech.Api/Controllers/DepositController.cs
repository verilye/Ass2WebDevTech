using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Ass2WebTech.Core.Services;
using Ass2WebTech.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Ass2WebTech.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepositController : ControllerBase
    {
        private readonly IUserService _userService;
        

        public DepositController (IUserService userService)
        {
            _userService = userService;
        }


        public class PostReq
        {
            public int id {get;set;}
            public double amount {get;set;}

            public string? comment {get;set;}
        
        }


        [HttpPost]
        public async Task<string> Deposit(PostReq req)
        {   

            Console.WriteLine("Bing Bong");

            var result = await _userService.Deposit(req.id, req.amount, req.comment);

            
            return "Deposited";
            
        }

    }
}