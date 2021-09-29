using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Helper;
using Xamarin.Services;
using Xamarin.Views;

namespace Xamarin.ViewModels
{
   public  class LoginViewModel
    {
        private readonly ApiServices _apiServices = new ApiServices();
        public INavigation _navigation;

        public string Username { get; set; }
        public string Password { get; set; }
        public ICommand LoginCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var accesstoken = await _apiServices.LoginAsync(Username, Password);

                    Setting.AccessToken = accesstoken;
                   

                });
            }
        }

        public LoginViewModel()
        {
            Username = Setting.Username;
            Password = Setting.Password;
        }
        }
}
