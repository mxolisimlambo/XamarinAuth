using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Base
{
    public interface IIndex
    {
        Guid Id { get; set; }
        DateTime DateCreated { get; set; }
        DateTime? DateLastEdited { get; set; }
        bool Deleted { get; set; }
    }
}
