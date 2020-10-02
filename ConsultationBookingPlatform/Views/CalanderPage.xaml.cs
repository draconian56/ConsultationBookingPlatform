using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConsultationBookingPlatform.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalanderPage : ContentPage
    {
        public int flag { get; private set; }

        DateTime dateAndTime;
        
        public CalanderPage()
        {
            InitializeComponent();
            
        }
        void OnDateSelected(object sender, DateChangedEventArgs args)
        {
            flag = 0;
            dateAndTime = Appointment.Date;
            
            string date =  dateAndTime.ToShortDateString();
            resultLabel.Text = String.Format("{0}", date);
           
        }
        void OnTimeChanged(object sender, PropertyChangedEventArgs args)
        {
            flag = 1;
            TimeSpan timepicked = AppointmentTime.Time;
            dateAndTime = dateAndTime.Date + timepicked;
        
            resultLabel.Text = String.Format("{0}", dateAndTime);
        }
       
    }
}