
using Abby.Models;
using AbbyWeb.DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Admin.FoodTypes
{
    [BindProperties]  
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;
    
        public FoodType FoodType { get; set; }
        public EditModel(ApplicationDbContext db) //implement the model class using the constructor.
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            FoodType = _db.FoodType.Find(id);
           // Category = _unitOfWork.Category.GetFirstOrDefault(u => u.Id == id);
            //Category = _db.Category.FirstOrDefault(u=>u.Id==id);
            //Category = _db.Category.SingleOrDefault(u=>u.Id==id);
            //Category = _db.Category.Where(u => u.Id == id).FirstOrDefault();
        }
        public async Task<IActionResult> OnPost()  //creating handler
        {
       
            if(ModelState.IsValid)
            {
                _db.FoodType.Update(FoodType); 
                await _db.SaveChangesAsync();
                TempData["Success"] = "FoodType Updated Successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
          
    }
}
