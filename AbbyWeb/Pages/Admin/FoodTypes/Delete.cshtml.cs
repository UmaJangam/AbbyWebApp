
using Abby.Models;
using AbbyWeb.DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Admin.FoodTypes
{
    [BindProperties]  
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;
    
        public FoodType FoodType { get; set; }
        public DeleteModel(ApplicationDbContext db) //implement the model class using the constructor.
        {
            _db = db;
        }
        public void OnGet(int id)
        {

            FoodType = _db.FoodType.Find(id);
        }
        public async Task<IActionResult> OnPost()  //creating handler
        {
          
                var foodTypeFromDb =  _db.FoodType.Find(FoodType.Id);
                if(foodTypeFromDb != null)
                {
                    _db.FoodType.Remove(foodTypeFromDb);
                    await _db.SaveChangesAsync();
                TempData["Success"] = "FoodType Deleted Successfully";
                return RedirectToPage("Index");
                }
            
            return Page();
        }
          
    }
}
