
using System.Data.Entity;

namespace tatoo_CRM.dataBase
{
    public class DataBaseContext:DbContext
    {
        public DbSet<Material> material { get; set; }
        public DbSet<Seans> seans { get; set; }
        public DataBaseContext() : base("DefaultConnection") { }
    }
}
