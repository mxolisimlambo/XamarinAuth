using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.ViewModels.Base
{
    public interface IEdit
    {
        Guid Id { get; set; }
        DateTime? DateLastEdited { get; set; }
    }
}
