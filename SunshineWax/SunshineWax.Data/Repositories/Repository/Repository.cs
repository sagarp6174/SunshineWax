using Microsoft.EntityFrameworkCore;
using SunshineWax.Data.Data;
using SunshineWax.Data.Repositories.IRepository;
using System.Linq.Expressions;

namespace SunshineWax.Data.Repositories.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        public DbSet<T> DbSet { get; set; }

        public Repository(ApplicationDbContext db)
        {
            _db = db;
            this.DbSet = db.Set<T>();
        }
        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = DbSet;
            query = query.Where(filter);
            return query.FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = DbSet;
            return query.ToList();
        }

        public void Remove(T entity)
        {
            DbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            DbSet.RemoveRange(entity);
        }
    }
}
