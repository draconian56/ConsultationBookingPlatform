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
using System.IO;

[assembly: Dependency(typeof(SqlConnection))]
namespace ConsultationBookingPlatform.iOS {
    public class SqlConnection {
        public SQLiteConnection Connection() {
            var fileName = "User.db3";
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentsPath, "..", "Library");
            var path = Path.Combine(libraryPath, fileName);
            var connection = new SQLite.SQLiteConnection(path);

            return connection;
        }
    }
}