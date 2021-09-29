using System;
using System.ComponentModel.DataAnnotations;

namespace Xamarin.Models.ViewModels.TimeShift
{
    public class EditViewModel : Base.EditViewModel
    {
        public string Name { get; set; }
   
        public string StartTime { get; set; }
        public Int16 Duration { get; set; }
    }
}
