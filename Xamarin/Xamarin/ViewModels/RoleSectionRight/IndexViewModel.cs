using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models.ViewModels.RoleSectionRight
{
    public class IndexViewModel : Base.IndexViewModel
    {
        public Guid RoleId { get; set; }
        public Guid SectionId { get; set; }
        public AccessRight AccessRight { get; set; }

        public virtual AppRole UserRole { get; set; }
        public virtual AppSection.IndexViewModel Section { get; set; }
    }
}
