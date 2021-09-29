using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XamarinAuth.Data
{
    public class Coach_mast
    {
        [Key]
        public int Coach_mastId { get; set; }
        public string Coach_name { get; set; }
      
    }
}
