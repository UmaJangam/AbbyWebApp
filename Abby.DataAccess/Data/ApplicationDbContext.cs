using Abby.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AbbyWeb.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext //it is in EntityFrameworkcore namespace
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) //to work for the connection string. it is a constructor. passing to the base class of dbcontext
        {

        }
        public DbSet<Category> Category { get;set;} //Name of the datatable in the database
        public DbSet<FoodType> FoodType { get; set; }
        public DbSet<MenuItem> MenuItem { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<ShoppingCart> ShoppingCart { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<OrderHeader> OrderHeader { get; set; }

    }
}
