using AbbyWeb.Model;
using Microsoft.EntityFrameworkCore;

namespace AbbyWeb.Data
{
    public class ApplicationDbContext : DbContext //it is in EntityFrameworkcore namespace
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) //to work for the connection string. it is a constructor. passing to the base class of dbcontext
        {

        }
        public DbSet<Category> Category { get;set;} //Name of the datatable in the database
    }
}
