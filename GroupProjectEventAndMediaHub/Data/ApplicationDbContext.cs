using GroupProjectEventAndMediaHub.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GroupProjectEventAndMediaHub.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Event> Events { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Photo> Photos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure foreign key relationship between Carts and Users
            modelBuilder.Entity<Cart>()
                .HasOne(c => c.Users)
                .WithMany(u => u.Carts)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.NoAction); // Prevent cascading delete

            // Configure foreign key relationship between Carts and Photos
            modelBuilder.Entity<Cart>()
                .HasOne(c => c.Photos)
                .WithMany()
                .HasForeignKey(c => c.PhotoId)
                .OnDelete(DeleteBehavior.NoAction); // Prevent cascading delete

            // Configure foreign key relationship between Events and Users (Organizer)
            modelBuilder.Entity<Event>()
                .HasOne(e => e.Users)
                .WithMany(u => u.Events)
                .HasForeignKey(e => e.OrganizerId)
                .OnDelete(DeleteBehavior.NoAction); // Prevent cascading delete

            // Configure foreign key relationship between Photos and Users
            modelBuilder.Entity<Photo>()
                .HasOne(p => p.Users)
                .WithMany(u => u.Photos)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.NoAction); // Prevent cascading delete

            // Fix here: Use the correct property name 'Category' (singular)
            modelBuilder.Entity<Photo>()
                .HasOne(p => p.Category)  // Use 'Category' instead of 'Categories'
                .WithMany()  // If needed, specify a collection property in Category (e.g., 'public ICollection<Photo> Photos')
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Cascade); // Optional: keep cascade if you want it
        }


    }
}
