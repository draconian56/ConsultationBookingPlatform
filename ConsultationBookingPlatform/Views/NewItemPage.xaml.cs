using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ConsultationBookingPlatform.Models;
using ConsultationBookingPlatform.ViewModels;

namespace ConsultationBookingPlatform.Views
{
    public partial class NewItemPage : ContentPage
    {
        

        public int flag { get; private set; }
        public Item Item { get; set; }
        DateTime dateAndTime;

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }

        void OnDateSelected(object sender, DateChangedEventArgs args)
        {
            flag = 0;
            dateAndTime = Appointment.Date;

            string date = dateAndTime.ToShortDateString();
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