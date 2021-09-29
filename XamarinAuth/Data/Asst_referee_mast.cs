using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XamarinAuth.Data
{
    public class Asst_referee_mast
    {
        [Key]
        public int Asst_referee_mastId { get; set; }
        public string Ass_ref_name { get; set; }
        
    }
}
