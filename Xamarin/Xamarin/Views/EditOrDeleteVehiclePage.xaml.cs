using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Models;
using Xamarin.ViewModels;

namespace Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditOrDeleteVehiclePage : ContentPage
    {
        public EditOrDeleteVehiclePage(Vehicle vehicle)
        {
            InitializeComponent();
            var editVehicleViewModel = new EditVehicleViewModel();
            //var editIdeaViewModel = BindingContext as EditIdeaViewModel;

            editVehicleViewModel.Vehicle = vehicle;

            BindingContext = editVehicleViewModel;
        }
      
    }
}