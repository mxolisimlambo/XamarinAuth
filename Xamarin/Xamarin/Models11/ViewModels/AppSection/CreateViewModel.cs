using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models.ViewModels.AppSection
{
    public class CreateViewModel : Base.CreateViewModel
    {
        public Guid Id { get; set; }
        public Guid ModuleId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? ParentId { get; set; }
    }
}
