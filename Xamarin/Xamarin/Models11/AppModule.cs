using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models
{
    public class AppModule : Entity
    {
       
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual IEnumerable<AppSection> Sections { get; set; }
    }
}
