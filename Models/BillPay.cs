using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ass2WebTech.Models
{
    public class BillPay
    {
        public int BillPayID{ get; set;}
        public int AccountNumber { get; set; }
        public int  PayeeID{ get; set; }
        public decimal Amount { get; set; }
        public DateTime ScheduleTimeUtc { get; set; }
        public char Period { get; set; }
    }
}