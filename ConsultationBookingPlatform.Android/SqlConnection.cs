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

[assembly: Xamarin.Forms.Dependency(typeof(SqlConnection))]

namespace ConsultationBookingPlatform.Droid {
    public class SqlConnection : ISqlConnection {
        public SQLiteConnection GetConnection() {
            var filename = "User.db3";
            var documentspath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentspath, filename);

            var connection = new SQLite.SQLiteConnection(path);
            return connection;
        }

    }
}