using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Helper;
using Xamarin.Models;
using Xamarin.Services;

using Xamarin.Forms.Xaml;
using Xamarin.Views;

namespace Xamarin.ViewModels
{
    public class VehicleViewModel : INotifyPropertyChanged 
    {
        Application obj = new Application();
        private readonly ApiServices _apiServices = new ApiServices();
        public string AccessToken { get; set; }
        public string Message { get; set; }
      
        public List<Vehicle> _Vehicles { get; set; }

        public List<Vehicle> Vehicles
        {
            get { return _Vehicles; }
            set
            {
                _Vehicles = value;
                OnPropertyChanged();
            }
        }
      
        public void GetListview()
        {
            Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new LoginPage());
        }
        public ICommand GetVehiclesCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var AccessToken = Setting.AccessToken;
                    if(AccessToken!="")
                    {
                        Vehicles = await _apiServices.GetVehiclesAsync(AccessToken);
                    }
             
                    Message= "Please Log in first";
                    GetListview();
                    //Settings.AccessToken = accesstoken;
                   

                });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
