using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ass2WebTech.Models
{
    public class Payee
    {   
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Required ]
        public int PayeeID{ get; set;}
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required,MaxLength(50)]
        public string Address{ get; set; }
        [Required, MaxLength(40)]
        public string City { get; set; }
        [Required]
        public State State { get; set; }
        [Required, RegularExpression("\\d\\d\\d\\d")]
        public string PostCode { get; set; }
        [Required, RegularExpression("\\(04\\)\\s\\d\\d\\d\\d\\s\\d\\d\\d\\d")]
        public string Phone { get; set; }
        
        
    }
}