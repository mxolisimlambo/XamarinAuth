using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models.ViewModels.RoleModuleRight
{
    public class CreateViewModel : Base.CreateViewModel
    {
        public Guid Id { get; set; }
        public Guid RoleId { get; set; }
        public Guid ModuleId { get; set; }
        public AccessRight AccessRight { get; set; }

    }
}
