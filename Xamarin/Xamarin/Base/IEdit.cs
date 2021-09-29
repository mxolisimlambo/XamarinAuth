using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Base
{
  public interface   IEdit
    {
        Guid Id { get; set; }
        DateTime? DateLastEdited { get; set; }
    }
}
