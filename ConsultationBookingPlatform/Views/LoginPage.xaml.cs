using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultationBookingPlatform.Database;
using ConsultationBookingPlatform.Models;
using ConsultationBookingPlatform.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConsultationBookingPlatform.Views {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage {
        public LoginViewModel LoginViewModel;
        public LoginPage() {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }
    }
}