﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models.ViewModels.Client
{
    public class CreateViewModel : Base.CreateViewModel
    {
        
        public string Name { get; set; }
        public Guid UserAccountId { get; set; }
    }
}
