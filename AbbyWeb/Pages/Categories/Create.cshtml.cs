using AbbyWeb.Data;
using AbbyWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Categories
{
    [BindProperties]  
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
    
        public Category Category { get; set; }
        public CreateModel(ApplicationDbContext db) //implement the model class using the constructor.
        {
            _db = db;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()  //creating handler
        {
            if(Category.Name == Category.DisplayOrder.ToString())
            {
                ModelState.AddModelError(Category.Name, "The DisplayOrder cannot exactly match the Name.");
            }
            if(ModelState.IsValid)
            {
                await _db.Category.AddAsync(Category);  //tells entity frame work to add the object category and add inside the category table
                await _db.SaveChangesAsync(); //save all the changes in the db
                TempData["Success"] = "Category Created Successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
          
    }
}
