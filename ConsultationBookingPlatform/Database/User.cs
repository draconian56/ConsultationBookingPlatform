using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ConsultationBookingPlatform.Database {
    public class User {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string email { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }

        public User() {

        }
    }
}
