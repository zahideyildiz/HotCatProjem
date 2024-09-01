using Bogus;
using HotCat.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace HotCat.DAL.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //Fluent Api
            //bir ürünün bir categorysi vardır. bir categorynin birden fazla ürünü bulunur.

            builder.HasOne(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.CategoryId);

            //Properties
            builder.Property(x => x.ProductName).IsRequired(true);
            builder.Property(x => x.ProductName).HasMaxLength(255);
            builder.Property(x => x.ImagePath).IsRequired(false);

            //HasData
            builder.HasData(SeedProductData());
        }

        public List<Product> SeedProductData()
        {
            var faker = new Faker("en");  //Datalar ingilizce adı ile oluşturulacak
            var products = new List<Product>();

            string[] coffeeNames = new string[]
            {
                "Espresso",
                "Espresso Macchiato",
                "Americano",
                "Latte",
                "Chai Tea Latte",
                "Cappuccino",
                "Flat White",
                "Affogato",
                "Cold Brew",
                "Turkish Coffee",
                "Iced Coffee",
                "Frappé"
            };

            string[] dessertsNames = new string[]
            {
                "Brownie",
                "Cookie",
                "Cheesecake",
                "Pie",
                "Muffin",
                "Waffle",
                "Pancake",
                "Tiramisu",
                "Brownie",
                "Macaron",
                "Profiterole",
                "Chocolate Fondue"
            };

            for (int i = 1; i <= 20; i++) 
            {
                string productName = faker.PickRandom(coffeeNames);
                if (faker.Random.Bool())
                {
                    productName = faker.PickRandom(dessertsNames);
                }
                Product product = new Product
                {
                    ID = i,
                    ProductName = faker.PickRandom(productName),
                    UnitPrice = decimal.Parse(faker.Commerce.Price()),
                    UnitsInStock = faker.Random.Short(0, 100),
                    ImagePath = faker.Image.PicsumUrl(),//Lorem PicsumURL den bize fake ımagepathler oluşturacaktır.
                    Discount = Math.Round(faker.Random.Double(0, 0.5), 2),
                    CategoryId = faker.Random.Number(1, 10)
                };

                products.Add(product);
            }
            return products;
        }
    }
}
