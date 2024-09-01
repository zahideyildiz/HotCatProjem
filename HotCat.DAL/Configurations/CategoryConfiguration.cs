using HotCat.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Bogus;

namespace HotCat.DAL.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //Properties
            builder.Property(x => x.Description).HasMaxLength(500);
            builder.Property(x => x.CategoryName).HasMaxLength(255).IsRequired(true);

            // Relationships
            builder.HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);

            //HasData: Veritabanında category tablosu oluşturulurken beraberinde varsayılan datalar ile birlikte oluşturulmasını sağlar. Propertyleri özelleştirdikten sonra ilgili kategoriye bizim burda tayin etmiş olduğumuz metottan dönen listeyi eklemesini sağlar.
            builder.HasData(SeedCategoryData());

        }

        //Bogus: Fake datalar oluşturulmasına olanak sağlayan ücretsiz bir kütüphanedir.
        private List<Category> SeedCategoryData() 
        {
            var faker = new Faker("en");

            var categories = new List<Category>();
            string[] categorieNames = new string[]
            {
                "Coffees",
                "Teas",
                "Cold Beverages",
                "Breakfast",
                "Salads",
                "Burgers",
                "Pizzas",
                "Desserts",
                "Cakes",
                "Ice Creams"
            };

            for (int i = 1; i <= categorieNames.Length; i++)
            {

                Category category = new Category
                {
                    ID = i,
                    CategoryName = categorieNames[i - 1],
                    Description = faker.Lorem.Sentence()
                };

                categories.Add(category);
            }
            return categories;
        }
    }
}
