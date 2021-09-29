using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Base
{
    public abstract class IndexViewModel : IIndex
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateLastEdited { get; set; }
        public bool Deleted { get; set; }
    }
}
