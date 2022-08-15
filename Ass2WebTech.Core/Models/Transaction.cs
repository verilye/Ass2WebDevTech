using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ass2WebTech.Models
{
    public class Transaction
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity),Required]
        public int TransactionID{ get; set;}

        [Required]
        public TransactionType TransactionType { get; set; }
        
        [Required]
        public int AccountNumber { get; set; }
        public int ?DestinationAccountNumber{ get; set; }

        [Required,Range(0,Double.MaxValue)]
        public double Amount { get; set; }

        [MaxLength(30)]
        public string ?Comment { get; set; }

        [Required]
        public DateTime TransactionTimeUtc { get; set; }

        Account Account {get;set;}
    }

    public enum TransactionType{
        Deposit = 'D',
        Withdraw= 'W',
        Transfer= 'T',
        ServiceCharge= 'S',
        BillPay= 'B',

    }
}