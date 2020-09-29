using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace ConsultationBookingPlatform.Database {
    public class credentials {
        public static string UEmail = "admin";
        public static string Password = "password";

        public async void GetCreds() {

            await Xamarin.Essentials.SecureStorage.SetAsync("isEmail", UEmail);
            await Xamarin.Essentials.SecureStorage.SetAsync("isPWord", Password);
        }
    }

}
