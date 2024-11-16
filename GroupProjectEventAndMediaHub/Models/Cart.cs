using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroupProjectEventAndMediaHub.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set;}
        public DateTime AddedDate { get; set; }
        public required virtual User Users { get; set; }
        public int UserId { get; set; }
        public required virtual Photo Photos { get; set; }
        public int PhotoId { get; set; }
    }
}
