using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ass2WebTech.Models
{
    public class Login
    {   

        public Login(string loginID, int customerID, string passwordHash){

            LoginID = loginID;
            CustomerID = customerID;
            PasswordHash = passwordHash;


        }
        [Key, Required, MinLength(8), MaxLength(8)][DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public string LoginID { get; set; }
        
        [Required]
        public int CustomerID{get;set;}
        
        [Required, MaxLength(64)]
        public string PasswordHash { get; set; }

        public Customer Customer{get;set;}
    }
}