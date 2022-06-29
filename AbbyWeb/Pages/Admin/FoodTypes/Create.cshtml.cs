
using Abby.Models;
using AbbyWeb.DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Admin.FoodTypes
{
    [BindProperties]  
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
    
        public FoodType FoodType { get; set; }
        public CreateModel(ApplicationDbContext db) //implement the model class using the constructor.
        {
            _db = db;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()  //creating handler
        {
            
            if(ModelState.IsValid)
            {
                await _db.FoodType.AddAsync(FoodType);  //tells entity frame work to add the object category and add inside the category table
                await _db.SaveChangesAsync(); //save all the changes in the db
                TempData["Success"] = "FoodType Created Successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
          
    }
}
