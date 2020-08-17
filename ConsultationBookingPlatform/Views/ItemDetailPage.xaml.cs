using System.ComponentModel;
using Xamarin.Forms;
using ConsultationBookingPlatform.ViewModels;

namespace ConsultationBookingPlatform.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}