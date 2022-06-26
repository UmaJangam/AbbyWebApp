using AbbyWeb.Data;
using AbbyWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Categories
{
    public class IndexModel : PageModel
    {

        private readonly ApplicationDbContext _db;
        public IEnumerable<Category> Categories { get; set; } //retrieve the data form the database in the form of list
        public IndexModel(ApplicationDbContext db) //implement the model class using the constructor.
        {
            _db = db;
        }
        public void OnGet()
        {
            Categories = _db.Category; //accepting the categories from the database
        }
    }
}
