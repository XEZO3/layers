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
    public class CoursesRepository : Repository<Courses>,ICoursesRepository
    {
        private readonly DataContext _context;
        public CoursesRepository(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
