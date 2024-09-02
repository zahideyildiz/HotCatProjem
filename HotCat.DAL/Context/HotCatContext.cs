using HotCat.DAL.Configurations;
using HotCat.Model.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotCat.DAL.Context
{
    public class HotCatContext:IdentityDbContext<AppUser, AppUserRole, Guid>
    {

        public HotCatContext(DbContextOptions<HotCatContext> options):base(options) { }


        //DB Sets

        //Category DbSet
        public DbSet<Category> Categories { get; set; } 

        //Product DbSet
        public DbSet<Product> Products { get; set; }

        //AppUser DbSet
        public DbSet<AppUser> AppUsers { get; set; }

        //Order DbSet

        public DbSet<Order> Orders { get; set; }

        //OrderDetail DbSet
        public DbSet<OrderDetail> OrderDetails { get; set; }



        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //        optionsBuilder.UseSqlServer("server=DESKTOP-JSABNAD\\SQLEXPRESS; database=HotCatProjem; Trusted_Connection=True;TrustServerCertificate=true");
        //    base.OnConfiguring(optionsBuilder);
        //}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Category Configuration
            builder.ApplyConfiguration(new CategoryConfiguration());

            //Product Configuration
            builder.ApplyConfiguration(new ProductConfiguration());

            //AppUser Configuration
            builder.ApplyConfiguration(new AppUserConfiguration());


            builder.ApplyConfiguration(new OrderConfiguration());

            builder.ApplyConfiguration(new OrderDetailConfiguration());


            base.OnModelCreating(builder);
        }
    }
}
