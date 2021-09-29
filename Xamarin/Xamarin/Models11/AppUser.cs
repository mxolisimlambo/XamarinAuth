using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models
{
    public class AppUser : IdentityUser<Guid>
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public virtual IEnumerable<UserModuleRight> UserModuleRights { get; set; }
        public virtual IEnumerable<UserSectionRight> UserSectionRights { get; set; }
        public virtual IEnumerable<DeliveryItemScan> DeliveryItemScans { get; set; }
    }

    public class AppRole : IdentityRole<Guid>
    {
        public DateTime DateCreated { get; set; } 
        public DateTime? DateLastEdited { get; set; }
        public bool Deleted { get; set; }

        public virtual IEnumerable<RoleModuleRight> RoleModuleRights { get; set; }
        public virtual IEnumerable<RoleSectionRight> RoleSectionRights { get; set; }

    }
}
