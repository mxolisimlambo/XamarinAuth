using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Models;

namespace Xamarin.ViewModels.CityTown
{
    public class IndexViewModel : Base.IndexViewModel
    {
        public string Name { get; set; }
        public string LongName { get { return Region != null ? $"{Name}, {Region.Name}" : Name; } }
        public Guid RegionId { get; set; }

        public virtual Region.IndexViewModel Region { get; set; }
    }
}
