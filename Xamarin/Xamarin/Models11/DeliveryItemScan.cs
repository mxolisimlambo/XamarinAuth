using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models
{
    public class DeliveryItemScan : Entity
    {
        public Guid DeliveryItemId { get; set; }
        public Guid UserId { get; set; }
        public Stage Stage { get; set; }

        public virtual DeliveryItem DeliveryItem { get; set; }
        public virtual AppUser User { get; set; }

    }
}
