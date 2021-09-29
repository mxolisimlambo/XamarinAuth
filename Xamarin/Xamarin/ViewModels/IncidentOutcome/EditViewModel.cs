using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models.ViewModels.IncidentOutcome
{
    public class EditViewModel : Base.EditViewModel
    {
        public string Name { get; set; }
        public Guid IncidentId { get; set; }
        public IncidentNextStep NextStep { get; set; }
    }
}
