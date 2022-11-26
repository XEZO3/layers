using DAL.Data;
using DAL.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DataContext _context;
        internal DbSet<T> dbSet;
        public Repository(DataContext context)
        {
            _context = context;
            dbSet = _context.Set<T>();
        }

        public void Add(T category)
        {
            
            dbSet.Add(category);
           
        }

        //public IEnumerable<T> GetAll(Expression<Func<T, bool>> exp = null)
        //{
        //    return dbSet.Where(exp).ToList();
        //}
        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T GetById(int Id)
        {
            return dbSet.Find(Id);
        }

        public void Remove(int Id)
        {
            var category = dbSet.Find(Id);
            dbSet.Remove(category);
            
        }

        public void Remove(T category)
        {
            dbSet.Remove(category);
            Save();
        }

        public void Update(T category)
        {
            dbSet.Update(category);
           
        }
        public void Save() {
            _context.SaveChanges();
        }
    }
}
