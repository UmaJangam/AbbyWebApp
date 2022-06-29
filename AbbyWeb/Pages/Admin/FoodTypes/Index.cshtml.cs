
using Abby.Models;
using AbbyWeb.DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Admin.FoodTypes
{
    public class IndexModel : PageModel
    {

        private readonly ApplicationDbContext _db;
        public IEnumerable<FoodType> FoodTypes { get; set; } //retrieve the data form the database in the form of list
        public IndexModel(ApplicationDbContext db) //implement the model class using the constructor.
        {
            _db = db;
        }
        public void OnGet()
        {
            FoodTypes = _db.FoodType; //accepting the categories from the database
        }
    }
}
