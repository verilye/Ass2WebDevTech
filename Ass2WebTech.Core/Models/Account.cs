using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ass2WebTech.Models
{
    public class Account
    {
        [Key, MaxLength(4), MinLength(4), Required]
        public int AccountNumber { get; set; }

        [Required]
        public AccountType AccountType { get; set; }
        [Required]
        public int CustomerID { get; set; }
        [Required]
        public double Balance { get; set; }
        
        public Customer Customer {get;set;}
        
        //public Transaction[] Transactions { get; set; }
    }

    public enum AccountType 
    {
        Checking ='C',
        Savings ='S'
    }
}