using ConsultationBookingPlatform.Views;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ConsultationBookingPlatform.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public Command IndividualCommand { get; }
        public Command BusinessCommand { get; }
        public AboutViewModel()
        {
            Title = "Consultation";
            //OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamain-quickstart"));
            IndividualCommand = new Command(IndiCommand);
            BusinessCommand = new Command(BusCommand);
            //var CalPage = new NavigationPage(new CalanderPage);
        }

        //public ICommand OpenWebCommand { get; }
        

        public async void IndiCommand()
        {
            //place holder for future delevopment
            
            await Shell.Current.Navigation.PushAsync(new NewItemPage());
        }
        public async void BusCommand()
        {
            //place holder for future delevopment
            await Shell.Current.Navigation.PushAsync(new NewItemPage());
        }
    }
}