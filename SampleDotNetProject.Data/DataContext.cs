using System.Data.Entity;
using SampleDotNetProject.Model.Entity;

namespace SampleDotNetProject.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=DataContext")
        {
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DataContext(string connectionString) : base(connectionString) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
