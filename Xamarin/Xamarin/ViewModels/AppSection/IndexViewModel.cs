using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.ViewModels.AppSection
{
    public class IndexViewModel : Base.IndexViewModel
    {
        public Guid ModuleId { get; set; }
    
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? ParentId { get; set; }

        public IndexViewModel Parent { get; set; }
        public virtual AppModule.IndexViewModel Module { get; set; }
    }
}
