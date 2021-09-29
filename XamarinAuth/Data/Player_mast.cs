using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XamarinAuth.Data
{
    public class Player_mast
    {
        [Key]
        public int Player_mastId { get; set; }       
        public int Jersey_no { get; set; }
        public int Player_name { get; set; }
        public int Playing_positionId { get; set; }
        public virtual Playing_position Playing_position { get; set; }
        public int Dt_of_bir { get; set; }
        public int Age { get; set; }
        public string Playing_club { get; set; }
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        public IEnumerable<Match_mast> Match_masts { get; set; }
        ////public IEnumerable<Goal_detail> Goal_details { get; set; }








    }
}
