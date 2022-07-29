using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ass2WebTech.Models
{
    public class Transaction
    {
        public int TransactionID{ get; set;}
        public char TransactionType { get; set; }
        public int AccountNumber { get; set; }
        public int DestinationAccountNumber{ get; set; }
        public decimal Amount { get; set; }
        public string Comment { get; set; }
        public DateTime TransactionTimeUtc { get; set; }
    }
}