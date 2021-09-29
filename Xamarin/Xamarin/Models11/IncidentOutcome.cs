using System;
using System.ComponentModel.DataAnnotations;

namespace Xamarin.Models
{
    public class IncidentOutcome : Entity
    {

        public string Name { get; set; }
        public Guid IncidentId { get; set; }
        public IncidentNextStep NextStep { get; set; }

        public virtual Incident Incident { get; set; }
    }
}