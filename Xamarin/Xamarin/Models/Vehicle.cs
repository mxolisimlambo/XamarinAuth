﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Xamarin.Models
{
  public  class Vehicle
    {

        public int VehicleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }

        public string UserId { get; set; }

    }
}
