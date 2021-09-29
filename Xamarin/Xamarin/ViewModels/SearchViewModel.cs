using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Models;
using Xamarin.Services;
using Xamarin.Helper;

namespace Xamarin.ViewModels
{
    public class SearchViewModel : INotifyPropertyChanged
    {
        private readonly ApiServices _apiServices = new ApiServices();
        private List<Vehicle> _ideas;

        public List<Vehicle> Ideas
        {
            get { return _ideas; }
            set
            {
                _ideas = value;
                OnPropertyChanged();
            }
        }

        public string Keyword { get; set; }

        public ICommand SearchCommand
        {
            get
            {
                return new Command(async () =>
                {
                    Ideas = await _apiServices.SearchVehiclesAsync(Keyword, Setting.AccessToken);
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
