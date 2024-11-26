using Microsoft.EntityFrameworkCore;
using  StaffAffairs.DataLayer.Models;
using  StaffAffairs.DataLayer.DBContext;
using StaffAffairs.BusinessLogic.Services;

namespace Services
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly StuffAppAppttContext _context;
        private readonly DbSet<T> _dbSet;

        public Service(StuffAppAppttContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet.AsQueryable();
        }

        public void save()
        {
            _context.SaveChanges();
        }
        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                _context.SaveChanges();
            }
        }
    }

};
// can create service class from different models
