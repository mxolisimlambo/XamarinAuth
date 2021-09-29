using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.ViewModels.AppModule
{
    public class EditViewModel : Base.EditViewModel
    {
     
 
        public string Name { get; set; }
 
        public string Description { get; set; }
    }
}
