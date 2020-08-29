using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ConsultationBookingPlatform.Services;
using ConsultationBookingPlatform.Views;

namespace ConsultationBookingPlatform
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            var isLoggedIn = Xamarin.Essentials.SecureStorage.GetAsync("isLogged").Result;
            var email = Database.credentials.UEmail;
            var pword = Database.credentials.Password;
            Xamarin.Essentials.SecureStorage.SetAsync("isEmail", email);
            Xamarin.Essentials.SecureStorage.SetAsync("isPWord", pword);

            if (isLoggedIn == "1")
            {
                MainPage = new AppShell();
            } else {
                MainPage = new LoginPage();
            }
        }

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
