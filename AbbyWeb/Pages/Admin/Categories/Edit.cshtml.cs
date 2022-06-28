
using Abby.Models;
using AbbyWeb.DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Admin.Categories
{
    [BindProperties]  
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;
    
        public Category Category { get; set; }
        public EditModel(ApplicationDbContext db) //implement the model class using the constructor.
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            Category = _db.Category.Find(id);
           // Category = _unitOfWork.Category.GetFirstOrDefault(u => u.Id == id);
            //Category = _db.Category.FirstOrDefault(u=>u.Id==id);
            //Category = _db.Category.SingleOrDefault(u=>u.Id==id);
            //Category = _db.Category.Where(u => u.Id == id).FirstOrDefault();
        }
        public async Task<IActionResult> OnPost()  //creating handler
        {
            if(Category.Name == Category.DisplayOrder.ToString())
            {
                ModelState.AddModelError(Category.Name, "The DisplayOrder cannot exactly match the Name.");
            }
            if(ModelState.IsValid)
            {
                _db.Category.Update(Category); 
                await _db.SaveChangesAsync();
                TempData["Success"] = "Category Updated Successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
          
    }
}
