using System;
using System.ComponentModel.DataAnnotations;

namespace Xamarin.Models.ViewModels.TimeShift
{
    public class CreateViewModel : Base.CreateViewModel
    {
        public string Name { get; set; }
    
        public string StartTime { get; set; }
        public Int16 Duration { get; set; }
    }
}
