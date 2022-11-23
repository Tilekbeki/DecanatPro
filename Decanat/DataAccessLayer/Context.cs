using Model2;
using System.Data.Entity;

namespace DataAccessLayer
{
    public class Context : DbContext
    {
        public Context() : base("DbConnection") { }
        public DbSet<Student> Students { get; set; }
    }
}
