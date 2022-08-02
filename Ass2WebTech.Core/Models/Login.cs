using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ass2WebTech.Models
{
    public class Login
    {
        public string LoginID { get; set; }
        public int CustomerID{get;set;}
        public string PasswordHash { get; set; }
    }
}