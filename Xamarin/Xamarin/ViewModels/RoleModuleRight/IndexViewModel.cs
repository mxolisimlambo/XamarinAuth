using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models.ViewModels.RoleModuleRight
{
    public class IndexViewModel : Base.IndexViewModel
    {
        public Guid RoleId { get; set; }
        public string Name { get; set; }
        public Guid ModuleId { get; set; }
        public AccessRight AccessRight { get; set; }

        //public virtual AppRole  UserRole { get; set; }
        public virtual AppModule.IndexViewModel Module { get; set; }



     
    }
}
