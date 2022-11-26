using DAL.IRepository;
using DAL.Repository;
using Models.DatabaseModels;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class CategoryService : ICategoryService
    {
        //private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;
        public CategoryService( IUnitOfWork unitOfWork)
        {
            //_categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
        }

        public void Add(Category category)
        {
            _unitOfWork.Category.Add(category);
            _unitOfWork.Save();
        }

        public IEnumerable<Category> GetAll()
        {
          return _unitOfWork.Category.GetAll();    
         }

        public Category GetById(int Id)
        {
            return _unitOfWork.Category.GetById(Id);
        }

        public void Remove(int Id)
        {
            _unitOfWork.Category.Remove(Id);
            _unitOfWork.Save();
        }

        public void Remove(Category category)
        {
            _unitOfWork.Category.Remove(category);
            _unitOfWork.Save();
        }

        public void Update(Category category)
        {
            _unitOfWork.Category.Update(category);
            _unitOfWork.Save();
        }
    }
}
