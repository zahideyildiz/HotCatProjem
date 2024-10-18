using HotCat.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace HotCat.DAL.Configurations
{
    public class TableConfiguration : IEntityTypeConfiguration<Table>
    {
        public void Configure(EntityTypeBuilder<Table> builder)
        {
            builder.Property(x => x.TableNumber).HasMaxLength(45);

            builder.HasMany(x => x.Orders)
                .WithOne(x => x.Table)
                .HasForeignKey(x => x.TableId);

            builder.HasData(SeedTable());
            
        }

        private List<Table> SeedTable()
        {
            List<Table> table = new List<Table>();

            for(int i = 1; i <= 10; i++)
            {
                table.Add(new Table
                {
                    ID = i,
                    TableName = $"Deniz Kenarı {i}",
                    TableNumber = $"{i}"
                });
            }

            return table;
        }

    }
}
