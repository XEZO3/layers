using DAL.Data;
using DAL.IRepository;
using Models.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly DataContext _context;
        public CategoryRepository(DataContext context) :base( context)
        {
            _context = context;
        }
        public void Add(Category category)
        {
            _context.Add(category);
            _context.SaveChanges();
        }

        public IEnumerable<Category> GetAll()
        {
           return _context.categories.ToList();
        }

        public Category GetById(int Id)
        {
            return _context.categories.Find(Id);
        }

        public void Remove(int Id)
        {
            _context.Remove(Id);
            _context.SaveChanges();
        }

        public void Remove(Category category)
        {
            _context.Remove(category);
            _context.SaveChanges();
        }

        public void Update(Category category)
        {
            _context.Update(category);
            _context.SaveChanges();
        }
    }
}
