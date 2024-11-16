﻿using System.ComponentModel.DataAnnotations;

namespace GroupProjectEventAndMediaHub.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
    }
}
