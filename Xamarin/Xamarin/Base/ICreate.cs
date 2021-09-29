using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Base
{
   public interface ICreate
    {
        DateTime DateCreated { get; set; }
        bool Deleted { get; set; }
    }
}
