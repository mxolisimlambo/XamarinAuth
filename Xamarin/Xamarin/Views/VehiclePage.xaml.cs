using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Models;

namespace Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VehiclePage : ContentPage
    {
        public VehiclePage()
        {
            InitializeComponent();
        }
        private async void NavigateToAddNewVehicle_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddVehiclePage());
        }

        private async void VehiclesListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vehicle = e.Item as Vehicle;
            await Navigation.PushAsync(new EditOrDeleteVehiclePage(vehicle ));
        }

        private async void NavigateToSearchvehicle_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SearchPage());
        }

        private async void LogoutMenuItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
        private async void NavigateToSearcNotes_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NoteEntryPage());
        }

    }
}