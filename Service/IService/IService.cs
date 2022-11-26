using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface IService<t>where t : class
    {
        IEnumerable<t> GetAll();
        t GetById(int Id);
        void Add(t category);
        void Update(t category);
        void Remove(int Id);
        void Remove(t category);
    }
}
