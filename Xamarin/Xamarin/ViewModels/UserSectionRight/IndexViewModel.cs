using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models.ViewModels.UserSectionRight
{
    public class IndexViewModel : Base.IndexViewModel
    {
        public Guid UserAccountId { get; set; }
        public Guid SectionId { get; set; }
        public AccessRight AccessRight { get; set; }

        public virtual AppUser UserAccount { get; set; }
        public virtual AppSection.IndexViewModel Section { get; set; }
    }
}
