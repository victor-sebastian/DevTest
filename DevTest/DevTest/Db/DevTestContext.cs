using DevTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTest.Db
{
    public class DevTestContext : DbContext
    {
        public DevTestContext()
            : base()
        {
            Database.SetInitializer<DevTestContext>(new DropCreateDatabaseIfModelChanges<DevTestContext>());
        }

        public DbSet<Character> Characters { get; set; }
    }
}
