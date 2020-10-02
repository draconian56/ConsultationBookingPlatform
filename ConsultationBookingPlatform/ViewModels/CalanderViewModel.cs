using System;
using System.Collections.Generic;
using System.Text;
using ConsultationBookingPlatform.Views;
using Syncfusion.SfCalendar.XForms;
using Xamarin.Forms;

namespace ConsultationBookingPlatform.ViewModels
{
    class CalanderViewModel : BaseViewModel
    {
        public Command SubmitCommand { get; }
        public CalanderViewModel()
        {
            Title = "Calander";
            // Create events 
            SubmitCommand = new Command(submitCommand);
        }
        public async void submitCommand()
        {
            //place holder for future delevopment

            await Shell.Current.Navigation.PushAsync(new HomePage());
        }
    }
}
