using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroupProjectEventAndMediaHub.Models
{
    public class Photo
    {
        [Key]
        public int PhotoId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }
        public DateTime UploadDate { get; set; }

        // Fixed the typo: changed 'Categorys' to 'Category'
        public required virtual Category Category { get; set; }  // Singular name 'Category'
        public int CategoryId { get; set; }

        public required virtual User Users { get; set; }
        public int UserId { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }
    }
}
