using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Base
{
    public abstract class EditViewModel : IEdit
    {
        public Guid Id { get; set ; }
        public DateTime? DateLastEdited { get; set ; }
    }
}
