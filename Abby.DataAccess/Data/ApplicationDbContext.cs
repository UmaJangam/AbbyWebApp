using Abby.Models;
using Microsoft.EntityFrameworkCore;

namespace AbbyWeb.DataAccess.Data
{
    public class ApplicationDbContext : DbContext //it is in EntityFrameworkcore namespace
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) //to work for the connection string. it is a constructor. passing to the base class of dbcontext
        {

        }
        public DbSet<Category> Category { get;set;} //Name of the datatable in the database
        public DbSet<FoodType> FoodType { get; set; } 
    }
}
