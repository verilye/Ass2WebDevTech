using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ass2WebTech.Models
{
    public class Login
    {   
        [Key, Required, MinLength(8), MaxLength(8)]
        public string LoginID { get; set; }
        [Required]
        public int CustomerID{get;set;}
        [Required, MaxLength(64)]
        public string PasswordHash { get; set; }
        Customer Customer{get;set;}
    }
}