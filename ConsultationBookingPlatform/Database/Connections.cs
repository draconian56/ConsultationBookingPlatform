using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ConsultationBookingPlatform.Database {
    public interface ISqlConnection {
        SQLiteAsyncConnection Connection();
        SQLiteConnection GetConnection();
    }
}
