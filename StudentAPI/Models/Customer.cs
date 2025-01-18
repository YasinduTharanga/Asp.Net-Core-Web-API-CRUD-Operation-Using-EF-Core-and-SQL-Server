using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentAPI.Models
{
    public class Customer
    {

        [Key]
        public int ListId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string CustName { get; set; } = "";
        public decimal Balance { get; set; }
        

    }
}
