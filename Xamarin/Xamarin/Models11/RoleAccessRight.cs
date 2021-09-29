using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models
{
    public class RoleModuleRight : Entity
    {
        public Guid RoleId { get; set; }
        public Guid ModuleId { get; set; }
        public AccessRight AccessRight { get; set; }

        public virtual AppRole UserRole { get; set; }
        public virtual AppModule Module { get; set; }
    }

    public class RoleSectionRight : Entity
    {
        public Guid RoleId { get; set; }
        public Guid SectionId { get; set; }
        public AccessRight AccessRight { get; set; }

        public virtual AppRole UserRole { get; set; }
        public virtual AppSection Section { get; set; }
    }
}
