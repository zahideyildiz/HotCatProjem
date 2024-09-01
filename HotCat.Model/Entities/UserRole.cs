using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotCat.Model.Entities
{
    public class UserRole:IdentityRole<Guid>
    {
        public string Description { get; set; }
        public DateTime AssignedDate { get; set; } = DateTime.Now;

        //Rolün sahip olduğu kullanıcılar

    }
}
