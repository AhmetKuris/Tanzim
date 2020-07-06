using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.Entity;
using Tanzim.Entities.Concrete;

namespace Tanzim.DataAccess.Concrete.EntityFramework
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class TanzimContext:DbContext
    {
        public TanzimContext()
        {
            Database.SetInitializer<TanzimContext>(null);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
