using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ass2WebTech.Models
{
    public class Transaction
    {
        public Transaction(char transactionType, int accountNumber, double amount, DateTime transactionTimeUtc, int? destinationAccountNumber, string? comment) 
        {
        
        this.TransactionType = transactionType;
        this.AccountNumber = accountNumber;
        this.Amount = amount;
        this.TransactionTimeUtc = transactionTimeUtc;
        this.DestinationAccountNumber = destinationAccountNumber;
   
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionID{ get; set;}

        [Required][MaxLength(1)][MinLength(1)]
        public char TransactionType { get; set; }

        [ForeignKey("AccountNumbers")]
        public int AccountNumber { get; set; }

        [ForeignKey("DestinationAccountNumbers")]
        public int? DestinationAccountNumber{ get; set; }

        [Required,Range(0,Double.MaxValue)]
        public double Amount { get; set; }

        [MaxLength(30)]
        public string? Comment { get; set; }

        [Required]
        public DateTime TransactionTimeUtc { get; set; }

        public Account Account{get;set;}

        public Account DestinationAccount{get;set;}

    }

    public enum TransactionType{
        Deposit = 'D',
        Withdraw= 'W',
        Transfer= 'T',
        ServiceCharge= 'S',
        BillPay= 'B',

    }
}