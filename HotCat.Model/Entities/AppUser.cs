using HotCat.Model.Enums;
using Microsoft.AspNetCore.Identity;

namespace HotCat.Model.Entities
{
    //nugettan microsoft.aspnetcore.identity.entityframeworkcore yükledik
    public class AppUser : IdentityUser<Guid>
    {
        public DateTime? BirthDate { get; set; }

        public string? Address { get; set; }

        public string? PhoneNumber { get; set; }

        public Gender? Gender { get; set; }

        // Mapping 
        public virtual List<Order> Orders { get; set; } // Kullanıcının verdiği siparişler
        public virtual List<AppUserRole> UserRoles { get; set; } = new List<AppUserRole>();  // Kullanıcının sahip olduğu roller
    }
}
