using Microsoft.EntityFrameworkCore;
using productsTemplate.Models;

namespace productsTemplate.DataContext
{
    public class DatabaseContext : DbContext 
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options)
        {
        }


        public DbSet<ProductsTable> ProductsTable { get; set; }
        public DbSet<Customer> Persons { get; set; }


    }

}
