using System;
using System.Collections.Generic;
using ConsultationBookingPlatform.ViewModels;
using ConsultationBookingPlatform.Views;
using Xamarin.Forms;

namespace ConsultationBookingPlatform
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
