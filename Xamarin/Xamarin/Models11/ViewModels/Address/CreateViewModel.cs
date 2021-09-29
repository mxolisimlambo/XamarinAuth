﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models.ViewModels.Address
{
    public class CreateViewModel : Base.CreateViewModel
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string ZipCode { get; set; }
        public Guid CityId { get; set; }
    }
}
