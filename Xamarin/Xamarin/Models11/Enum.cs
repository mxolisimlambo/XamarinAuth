using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models
{
    public enum AccessRight
    {
        Read,
        ReadAndWrite,
        Deny
    }

    public enum Stage
    {
        Start,
        Pickup,
        Delivery,
        End
    }

    public enum Status
    {
        Pending,
        Loaded,
        Transit,
        Completed,
        Delayed,
        Canceled
    }

    public enum IncidentNextStep
    {
        Continue,
        Cancellation,
        ChangeRoute
    }
}
