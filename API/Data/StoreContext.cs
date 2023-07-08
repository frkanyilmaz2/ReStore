using API.Entities;
using Microsoft.EntityFrameworkCore;
namespace API.Data
{
    public class StoreContext : DbContext
    {
        //similar to opening a connection to mongodb
        public StoreContext(DbContextOptions options) : base(options)
        {

        }

        //DBset means a table in database. Every property in products will be a column name
        public DbSet<Product> Products { get; set; }
    }
}