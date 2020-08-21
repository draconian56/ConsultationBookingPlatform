using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using SQLite;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ConsultationBookingPlatform.Database;
using ConsultationBookingPlatform.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Shapes;
using System.IO;
using Environment = Android.OS.Environment;

[assembly: Xamarin.Forms.Dependency(typeof(SQLiteAsyncConnection))]

namespace ConsultationBookingPlatform.Droid {
    public class SqlConnection {
        public SQLiteConnection Connection() {
            var filename = "User.db3";
            var documentspath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = System.IO.Path.Combine(documentspath, filename);

            var connection = new SQLite.SQLiteConnection(path);
            return connection;
        }

    }
}