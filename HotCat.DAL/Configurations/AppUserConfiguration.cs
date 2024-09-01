using Bogus;
using HotCat.Model.Entities;
using HotCat.Model.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotCat.DAL.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {

            builder.HasKey(u => u.Id);

            builder.Property(u => u.UserName)
                .IsRequired()
                .HasMaxLength(256); // Username için maksimum değer 

            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(256); // Email için maksimum değer 

            // Optional
            builder.HasIndex(u => u.UserName)
                   .IsUnique(); // Benzersiz kullanıcı adı sağlar

            builder.HasIndex(u => u.Email)
                   .IsUnique(); // Benzersiz email sağlar

            builder.Property(u => u.BirthDate)
                .HasColumnType("date").IsRequired(false); 

            builder.Property(u => u.Address).IsRequired(false)
                .HasMaxLength(500); // Adres için maksimum değer


            builder.Property(u => u.Gender)
                .HasConversion(v => v
                .ToString()
                , v => (Gender)Enum
                .Parse(typeof(Gender), v))
                .IsRequired(false);

            // Kullanıcı adı ve e-posta alanlarının benzersiz olduğunu belirtin
            builder.HasIndex(u => u.UserName).IsUnique();
            builder.HasIndex(u => u.Email).IsUnique();

            // AppUser ile ilişkili koleksiyonlar
            builder.HasMany(u => u.Orders)
                .WithOne(o => o.AppUser)
                .HasForeignKey(o => o.AppUserId);


            //builder.HasMany(u => u.UserRoles)
            //    .WithOne(ur => ur.User)
            //    .HasForeignKey(ur => ur.UserId);

        }

        //public List<AppUser> SeedAppUserData()
        //{
        //    var faker = new Faker("en");// datalar ingilizce adı ile oluşturulacak
        //    var Users = new List<AppUser>();

        //    for (int i = 0; i <= 15; i++)
        //    {
        //        AppUser user = new AppUser()
        //        {
        //            Id = faker.Random.Guid(),
        //            BirthDate = faker.Date.Past(30, DateTime.Now.AddYears(-18)),//18 yaşından büyük olmalı
        //            UserName = faker.Internet.UserName(),
        //            Email = faker.Internet.Email(faker.Internet.UserName()).ToLower(),
        //            PasswordHash = faker.Internet.Password(8),
        //            Address = faker.Address.FullAddress(),
        //            Gender = faker.PickRandom<Gender>(),
        //            PhoneNumber = faker.Phone.PhoneNumber(),

        //        };
        //        Users.Add(user);
        //    };
        //    return Users;
        //}
    }
}
