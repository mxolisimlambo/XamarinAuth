using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Models;
using Xamarin.Services;

namespace Xamarin.ViewModels
{
   public class EditVehicleViewModel
    {
        ApiServices _apiServices = new ApiServices();
        public Vehicle Vehicle { get; set; }

        //public ICommand PutCommand
        //{
        //    get
        //    {
        //        return new Command(async () =>
        //        {
        //            await _apiServices.PutIdeaAsync(Vehicle, Settings.AccessToken);
        //        });
        //    }
        //}
        //public ICommand DeleteCommand
        //{
        //    get
        //    {
        //        return new Command(async () =>
        //        {
        //            await _apiServices.DeleteIdeaAsync(Vehicle.VehicleId, Settings.AccessToken);
        //        });
        //    }
        //}
    }
}
