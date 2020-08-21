using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using SQLitePCL;
using Xamarin.Forms;

namespace ConsultationBookingPlatform.Database {
    public class UserDB {
        private SQLiteConnection _sqlconnection;

        // Initialse connection and creating the table
        public UserDB() {
            _sqlconnection = DependencyService.Get<SQLiteAsyncConnection>().GetConnection();
            _sqlconnection.CreateTable<User>();
        }

        // Get all users
        public IEnumerable<User> GetUser() {
            return (from t in _sqlconnection.Table<User>() select t).ToList();
        }
        
        // Get single user
        public User GetUser(int id) {
            return _sqlconnection.Table<User>().FirstOrDefault(t => t.Id == id);
        }

        // Add new user
        public void AddUser(User user) {
            _sqlconnection.Insert(user);
        }
    }
}
