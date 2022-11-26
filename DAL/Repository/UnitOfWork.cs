using DAL.Data;
using DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        public UnitOfWork(DataContext context) { 
        _context = context;
            Category = new CategoryRepository(_context);
            Courses = new CoursesRepository(_context);
        }

        public ICategoryRepository Category { get; private set; }
        public ICoursesRepository Courses { get; private set; }
        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
