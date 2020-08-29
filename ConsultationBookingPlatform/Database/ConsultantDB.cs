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
    public class ConsultantDB {
        static readonly Lazy<SQLiteAsyncConnection> lazyInitialiser = new Lazy<SQLiteAsyncConnection>(() => {
            return new SQLiteAsyncConnection(ConsulConstants.DatabasePath, ConsulConstants.Flags);
        });

        static SQLiteAsyncConnection Database => lazyInitialiser.Value;
        static bool initialised = false;

        public ConsultantDB() {
            InitializeAsync().SafeFireAndForget(false);
        }

        async Task InitializeAsync() {
            if (!initialised) {
                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(Consultant).Name)) {
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(Consultant)).ConfigureAwait(false);
                }
                initialised = true;
            }
        }

        // Add commands for functionality here
    }
}
