using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace GroupProjectEventAndMediaHub.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }

    }
}
