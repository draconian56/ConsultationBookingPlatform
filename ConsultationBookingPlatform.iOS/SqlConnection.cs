using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using ConsultationBookingPlatform.Database;
using ConsultationBookingPlatform.iOS;
using SQLite;

[assembly: Dependency(typeof(SqlConnection))]
namespace ConsultationBookingPlatform.iOS {
    class SqlConnection : ISqlConnection {
        public SQLiteAsyncConnection Connection() {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = System.IO.Path.Combine(documentsPath, "MySQLite.sqldb");

            return new SQLiteAsyncConnection(path);
        }
    }
}