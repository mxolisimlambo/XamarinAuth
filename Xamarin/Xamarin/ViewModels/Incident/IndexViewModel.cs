using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models.ViewModels.Incident
{
    public class IndexViewModel : Base.IndexViewModel
    {
        public Int16 Severity { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
