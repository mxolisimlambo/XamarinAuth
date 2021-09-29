﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models.ViewModels.Role
{
    public class CreateViewModel : Base.CreateViewModel
    {
    
        public string Name { get; set; }

        public virtual Role.CreateViewModel role { get; set; }
    }
}
