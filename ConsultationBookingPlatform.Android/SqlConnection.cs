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
    class SqlConnection : ISqlConnection {
        public SQLiteAsyncConnection Connection() {
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var path = System.IO.Path.Combine(documentsPath, "MySQLite.ldb");

            return new SQLiteAsyncConnection(path);
        }

    }
}