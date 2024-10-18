using HotCat.DAL.Configurations;
using HotCat.Model.Base;
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

        //Table DbSet

        public DbSet<Table> Tables { get; set; }

        //Savechanges değişiklikleri kaydet demek. Burada kullanma amacımız da yapılan değişiklikleri veritabanına aktarmak.
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            try
            {
                var modifiedEntries = ChangeTracker.Entries().Where(x => x.State == EntityState.Modified);

                foreach (var item in modifiedEntries)
                {

                    var entityRepository = item.Entity as BaseEntity;

                    if (item.State == EntityState.Modified)
                    {
                        entityRepository.UpdatedDate = DateTime.Now;
                        entityRepository.UpdatedIpAddress = "";
                        entityRepository.UpdatedComputerName = System.Environment.MachineName;

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }


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

            builder.ApplyConfiguration(new TableConfiguration());


            base.OnModelCreating(builder);
        }
    }
}
