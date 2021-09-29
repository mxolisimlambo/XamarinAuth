using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.ViewModels.Base
{
    public interface IIndex
    {
        Guid Id { get; set; }
        DateTime DateCreated { get; set; }
        DateTime? DateLastEdited { get; set; }
        bool Deleted { get; set; }
    }
}
