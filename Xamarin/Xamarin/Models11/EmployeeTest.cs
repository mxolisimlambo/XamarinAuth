using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models
{
   public  class EmployeeTest
    {

       
          
            public int Id { get; set; }
           
            public string FirstName { get; set; }
            public string LastName { get; set; }
          
            public string Email { get; set; }
           
            public int Mobile { get; set; }
            public string Company { get; set; }
        
    }
}
