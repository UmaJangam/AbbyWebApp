using AbbyWeb.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Abby.DataAccess.Repository.IRepository;

namespace Abby.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;

        public Repository(ApplicationDbContext db) //implement the model class using the constructor.
        {
            _db = db;
            //_db.MenuItem.Include(u => u.FoodType).Include(u => u.Category); //FoodType,Category...map the food type id and category id 
            //_db.MenuItem.OrderBy(u => u.Name);
            this.dbSet = db.Set<T>(); //connect to the dbcontext internally
        }
        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null,
             Func<IQueryable<T>, IOrderedQueryable<T>>? orderby = null,
            string? includeProperties = null)
        {
            IQueryable<T> query = dbSet;       //same Index.cshtml.cs  FoodTypes = _db.FoodType accepting in lists
            if(includeProperties != null)
            {//abc,,xyz-> abc xyz
                foreach(var includeProperty in includeProperties.Split(
                    new char[] {','},StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }
            if(orderby != null)
            {
                return orderby(query).ToList();
            }
            return query.ToList();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>>? filter = null, string? includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);      //filter for every condition with where
            }
            if (includeProperties != null)
            {//abc,,xyz-> abc xyz
                foreach (var includeProperty in includeProperties.Split(
                    new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }
            return query.FirstOrDefault();
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
        }
    }
}
