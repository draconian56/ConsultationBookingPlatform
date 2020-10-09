using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using ConsultationBookingPlatform.Models;
using Xamarin.Forms;

namespace ConsultationBookingPlatform.ViewModels
{
    public class NewItemViewModel : BaseViewModel
    {
        
        private string description;
        
        public NewItemViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
            
        }
       
        private string _resultlabel;

        
        public string resultlabel
        {
            get => _resultlabel;

            set => SetProperty(ref _resultlabel, value);

        }
        
        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(_resultlabel)
                && !String.IsNullOrWhiteSpace(description);
        }

        

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        private async void OnSave()
        {
            Item newItem = new Item()
            {
                Id = Guid.NewGuid().ToString(),
                Text = resultlabel,
                Description = Description
            };

            await DataStore.AddItemAsync(newItem);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}
