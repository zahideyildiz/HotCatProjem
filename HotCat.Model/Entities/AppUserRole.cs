using Microsoft.AspNetCore.Identity;

namespace HotCat.Model.Entities
{
    public class AppUserRole : IdentityRole<Guid>
    {
        public string Description { get; set; }

    }
}
