using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models
{
    public class AppSection : Entity 
    {
        public Guid ModuleId { get; set; }
       
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? ParentId { get; set; }

        public virtual AppSection Parent { get; set; }
        public virtual AppModule Module { get; set; }
    }
}
