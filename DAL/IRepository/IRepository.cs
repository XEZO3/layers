using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IRepository<T> where T : class
    {
        //IEnumerable<T> GetAll(Expression<Func<T,bool>> exp = null);
        IEnumerable<T> GetAll();
        T GetById(int Id);
        void Add(T category);
        void Update(T category);
        void Remove(int Id);
        void Remove(T category);
        void Save();
    }
}
