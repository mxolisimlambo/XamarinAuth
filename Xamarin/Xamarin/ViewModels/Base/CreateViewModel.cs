using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.ViewModels.Base
{
    public abstract class CreateViewModel : ICreate
    {
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public bool Deleted { get; set; } = false;

    }
}
