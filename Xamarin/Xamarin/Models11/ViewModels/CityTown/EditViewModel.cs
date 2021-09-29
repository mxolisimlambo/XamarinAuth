using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models.ViewModels.CityTown
{
    public class EditViewModel : Base.EditViewModel
    {
        public string Name { get; set; }
        public Guid RegionId { get; set; }
    }
}
