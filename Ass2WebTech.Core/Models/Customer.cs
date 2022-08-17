using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ass2WebTech.Models
{
    public class Customer
    {

        public Customer (string city, string name, int customerID, string address)
        {
            CustomerID = customerID;
            Name = name;
            City = city;
            Address = address;             
    
        }

        [Key, MinLength(4), MaxLength(4), Required][DatabaseGeneratedAttribute(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(11),RegularExpression("\\d\\d\\d\\s\\d\\d\\d\\s\\d\\d\\d")]
        public string ?TFN {get;set;}

        [MaxLength(50)]
        public string ?Address { get; set; }

        [MaxLength(50)]
        public string ?City { get; set; }
        public State State{get;set;}

        [MaxLength(4),RegularExpression("\\d\\d\\d\\d|null")]
        public int? PostCode { get; set; }

        [MaxLength(12), RegularExpression("04\\d\\d\\s\\d\\d\\d\\s\\d\\d\\d")]
        public string ?Mobile {get;set;}

        public Login Login{get;set;}

        [ForeignKey("CustomerID")]
        public ICollection<Account> Accounts{get;set;}

       

       }
    public enum State 
    {
        QLD,
        NSW,
        ACT,
        VIC,
        WA,
        SA,
        TAS
    }
}