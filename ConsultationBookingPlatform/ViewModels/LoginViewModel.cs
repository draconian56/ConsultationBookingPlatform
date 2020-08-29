using ConsultationBookingPlatform.Database;
using ConsultationBookingPlatform.Models;
using ConsultationBookingPlatform.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;


namespace ConsultationBookingPlatform.ViewModels 
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public Command LoginCommand { get; }
        private LoginModel loginModel = new LoginModel();

        public event PropertyChangedEventHandler PropertyChanged;

        public LoginModel LoginModel
        {
            get { return loginModel; }
            set {
                loginModel = value;
                OnPropertyChanged();
            }
        }
        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }
        

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private async void OnLoginClicked(object obj) 
        {         
            var isemail = Xamarin.Essentials.SecureStorage.GetAsync("isEmail").Result;
            var isPword = Xamarin.Essentials.SecureStorage.GetAsync("isPWord").Result;
            if (LoginModel.Password == isPword && LoginModel.UEmail == isemail)
            {
                await App.Current.MainPage.DisplayAlert("Notification", "Successfully Login", "Okay");
                await Xamarin.Essentials.SecureStorage.SetAsync("isLogged", "1");
                Application.Current.MainPage = new AppShell();
                await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
            } else {
                await App.Current.MainPage.DisplayAlert("Notification", "Wrong email or password", "Okay");
                await Xamarin.Essentials.SecureStorage.SetAsync("isLogged", "0");
            }
        }
    }
}
