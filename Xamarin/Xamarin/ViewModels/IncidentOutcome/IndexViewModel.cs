using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models.ViewModels.IncidentOutcome
{
    public class IndexViewModel : Base.IndexViewModel
    {
        public string Name { get; set; }
        public IncidentNextStep NextStep { get; set; }
    }
}
