using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models
{
    public class UserModuleRight : Entity
    {
        public Guid UserAccountId { get; set; }
        public Guid ModuleId { get; set; }
        public AccessRight AccessRight { get; set; }

        public virtual AppUser UserAccount { get; set; }
        public virtual AppModule Module { get; set; }

    }
}
