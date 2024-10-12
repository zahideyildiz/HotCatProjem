using Azure.Identity;
using Bogus;
using HotCat.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotCat.DAL.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            // Primary key
            builder.HasKey(x => x.ID);
            // OrderDate alanı için varsayılan değer ve adını belirleme
            builder.Property(o => o.OrderDate)
            .IsRequired();

            // TotalAmount alanı için gereksinimler
            builder.Property(o => o.TotalAmount)
            .HasColumnType("decimal(18,2)")
            .IsRequired(false);  // Decimal alan türü ve hassasiyeti



            // Relationships configuration
            builder.HasMany(o => o.OrderDetails)
                .WithOne(od => od.Order)
                .HasForeignKey(od => od.OrderId).OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(o => o.AppUser)
               .WithMany(u => u.Orders)
               .HasForeignKey(o => o.AppUserId);




            builder.HasData(SeedOrderData());

        }
        private List<Order> SeedOrderData()
        {
            var faker = new Faker("en");

            // Fake order data
            var orders = new List<Order>();


            for (int i = 1; i <= 20; i++)
            {
                Order order = new Order
                {
                    ID = i,
                    OrderDate = faker.Date.Past(1),
                    TotalAmount = decimal.Parse(faker.Commerce.Price(10, 500)) // Ensure amount range
                    
                };

                orders.Add(order);
            }

            return orders;
        }
    }
    
}
