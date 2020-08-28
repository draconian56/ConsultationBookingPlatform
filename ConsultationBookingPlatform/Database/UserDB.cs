using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SQLite;
using SQLitePCL;
using Xamarin.Forms;

namespace ConsultationBookingPlatform.Database {
    public class UserDB {
        static readonly Lazy<SQLiteAsyncConnection> lazyInitialiser = new Lazy<SQLiteAsyncConnection>(() => {
            return new SQLiteAsyncConnection(UserConstants.DatabasePath, UserConstants.Flags);
        });

        static SQLiteAsyncConnection Database => lazyInitialiser.Value;
        static bool initialised = false;

        public UserDB() {
            InitializeAsync().SafeFireAndForget(false);
        }

        async Task InitializeAsync() {
            if (!initialised) {
                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(User).Name)) {
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(User)).ConfigureAwait(false);
                }
                initialised = true;
            }
        }

        // Add in commands here, either using SQL or C# ORM. I will get to it later.
    }
}
