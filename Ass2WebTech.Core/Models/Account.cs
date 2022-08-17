using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ass2WebTech.Models
{
    public class Account
    {

        public Account(int accountNumber, char accountType, int customerID, double balance) 
        {
            this.AccountNumber = accountNumber;
            this.AccountType = accountType;
            this.CustomerID = customerID;
            this.Balance = balance;
        }
        
        [Key, MaxLength(4), MinLength(4), Required][DatabaseGeneratedAttribute(DatabaseGeneratedOption.None)]
        public int AccountNumber { get; set; }

        [Required]
        public char AccountType { get; set; }

        [Required]
        public int CustomerID { get; set; }
        [Required]
        public double Balance { get; set; }        
        
        public Customer Customer {get;set;}


        [ForeignKey("AccountNumber")]
        public ICollection<BillPay> BillPays{get;set;}


        [ForeignKey("AccountNumber")]
        public ICollection<Transaction> AccountNumbers{get;set;}
        
        [ForeignKey("DestinationAccountNumber")]
        public ICollection<Transaction> DestinationAccountNumbers{get;set;}

       



    }

    public enum AccountType 
    {
        Checking ='C',
        Savings ='S'
    }
}