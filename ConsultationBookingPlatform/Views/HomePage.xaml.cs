using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ConsultationBookingPlatform.ViewModels;

namespace ConsultationBookingPlatform.Views
{
  
    public partial class HomePage : ContentPage
    {
        HomeViewModel _viewModel1;
        public HomePage()
        {
            InitializeComponent();
            BindingContext = _viewModel1 = new HomeViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel1.OnAppearing();
        }
    }
}