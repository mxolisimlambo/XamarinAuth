using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.ViewModels.Base
{
    public interface ICreate
    {
        DateTime DateCreated { get; set; }
        bool Deleted { get; set; }
    }
}
