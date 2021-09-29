using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XamarinAuth.Data
{
    public class Playing_position
    {
        [Key]
        public int Playing_positionId { get; set; }
        public string Position_desc { get; set; }
        public IEnumerable<Player_mast> Player_masts { get; set; }


    }
}
