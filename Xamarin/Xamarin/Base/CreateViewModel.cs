using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Base
{
    public abstract class CreateViewModel : ICreate
    {
        public DateTime DateCreated { get ; set; }
        public bool Deleted { get ; set ; }
    }
}
