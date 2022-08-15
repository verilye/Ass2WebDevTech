using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ass2WebTech.Models
{
    public class BillPay
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Required]
        public int BillPayID{ get; set;}
        [Required]
        public int AccountNumber { get; set; }
        [Required]
        public int  PayeeID{ get; set; }
        [Required,Range(0,Double.MaxValue)]
        public double Amount { get; set; }
        [Required]
        public DateTime ScheduleTimeUtc { get; set; }
        [Required]
        public Period Period { get; set; }

        public Account Account{get;set;}
        public Payee Payee {get;set;}
    }

    public enum Period 
    {
        OneOff ='O',
        Monthly ='M'
    }
}