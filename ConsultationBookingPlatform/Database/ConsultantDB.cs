using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace ConsultationBookingPlatform.Database {
    class ConsultantDB {
        private SQLiteConnection _sqlconnection;

        // Initialse connection and creating the table
        public ConsultantDB() {
            _sqlconnection = DependencyService.Get<ISQLite>().GetConnection();
            _sqlconnection.CreateTable<Consultant>();
        }

        // Get all consultants
        public IEnumerable<Consultant> GetConsultant() {
            return (from t in _sqlconnection.Table<Consultant>() select t).ToList();
        }

        // Get single consultant
        public Consultant GetConsultant(int id) {
            return _sqlconnection.Table<Consultant>().FirstOrDefault(t => t.Id == id);
        }

        // Add new consultant
        public void AddConsultant(Consultant consultant) {
            _sqlconnection.Insert(consultant);
        }
    }
}
