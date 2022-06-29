using AbbyWeb.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Abby.DataAccess.Repository.IRepository;

namespace Abby.DataAccess.Repository
{
    public class Repository<T> : IRepository <T> where T : class
    {
       
    }
}
