using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.ViewModels.Base
{
    public abstract class IndexViewModel : IIndex
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateLastEdited { get; set; }
        public bool Deleted { get; set; }
    }
}
