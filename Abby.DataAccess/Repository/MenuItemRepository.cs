
using Abby.Models;
using AbbyWeb.DataAccess.Data;

namespace Abby.DataAccess.Repository.IRepository
{
    public class MenuItemRepository : Repository<MenuItem>, IMenuItemRepository
    {
        private readonly ApplicationDbContext _db;
        public MenuItemRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(MenuItem obj)
        {
            var ObjFromDb = _db.MenuItem.FirstOrDefault(u => u.Id == obj.Id); //this will retrive the category obj from the database
            ObjFromDb.Name = obj.Name;
            ObjFromDb.Description = obj.Description;
            ObjFromDb.Price = obj.Price;
            ObjFromDb.CategoryId = obj.CategoryId;
            ObjFromDb.FoodTypeId = obj.FoodTypeId;
            if(ObjFromDb.Image!=null)
            {
                ObjFromDb.Image = obj.Image;
            }
        }
    }
}
