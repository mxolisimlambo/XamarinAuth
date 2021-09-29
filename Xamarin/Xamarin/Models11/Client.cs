using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models
{
    public class Client : Entity
    {
       
        public string Name { get; set; }
        public Guid UserAccountId { get; set; }

        public virtual AppUser UserAccount { get; set; }
        public virtual IEnumerable<DeliveryNote> DeliveryNotes { get; set; }
    }
}
