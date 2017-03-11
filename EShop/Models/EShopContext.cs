using System.Data.Entity;

namespace EShop.Models
{
    public class EShopContext:DbContext
    {
        public EShopContext():base("EShop")
        {
            
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRole>()
                   .HasMany(e => e.AspNetUsers)
                   .WithMany(e => e.AspNetRoles)
                   .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);
            base.OnModelCreating(modelBuilder);
        }
    }
}