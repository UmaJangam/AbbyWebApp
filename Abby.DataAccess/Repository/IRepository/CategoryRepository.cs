using Abby.Models;
using AbbyWeb.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abby.DataAccess.Repository.IRepository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Save()
        {
           _db.SaveChanges();
        }

        public void Update(Category category)
        {
           var ObjFromDb = _db.Category.FirstOrDefault(u => u.Id == category.Id); //this will retrive the category obj from the database
            ObjFromDb.Name = category.Name;
            ObjFromDb.DisplayOrder = category.DisplayOrder; //updating the name and category based on id
        }
    }
    
}
