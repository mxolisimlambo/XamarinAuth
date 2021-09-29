using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models
{
    public class UserSectionRight : Entity
    {
        public Guid UserAccountId { get; set; }
        public Guid SectionId { get; set; }
        public AccessRight AccessRight { get; set; }

        public virtual AppUser UserAccount { get; set; }
        public virtual AppSection Section { get; set; }

    }
}
