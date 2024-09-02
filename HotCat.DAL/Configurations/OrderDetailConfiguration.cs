using HotCat.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotCat.DAL.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {

            builder.Ignore(x => x.ID);
            builder.HasKey(x => new { x.ProductId, x.OrderId });
            builder.Property(x => x.Quantity).IsRequired();
            builder.Property(od => od.UnitPrice); // UnitPrice alanı için veri tipi ve uzunluk belirlendi


            // OrderDetail ile Order arasında çokluk ilişkisi
            builder.HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderId).OnDelete(DeleteBehavior.Restrict);

            //OrderDetail ile Product arasında çokluk ilişkisi
            builder.HasOne(od => od.Product)
                .WithMany(x => x.OrderDetails)
                .HasForeignKey(od => od.ProductId).OnDelete(DeleteBehavior.Restrict); // Restrict ile Product silindiğinde OrderDetail'lar silinmez
        }
    }
}
