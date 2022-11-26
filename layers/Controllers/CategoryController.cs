﻿using Microsoft.AspNetCore.Mvc;
using Models.DatabaseModels;
using Service.IService;
using Service.Service;

namespace layers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public IEnumerable<Category> GetAll() {
            return _categoryService.GetAll();
        }
        [HttpPost]
        public void Add([FromForm] Category category) {
            _categoryService.Add(category);
        }
        [HttpDelete]
        public void remove(int Id)
        {
            _categoryService.Remove(Id);
        }
        //public void remove(Category category)
        //{
        //    _categoryService.Remove(category);
        //}
        [HttpPatch]
        public void update(Category category)
        {
            _categoryService.Update(category);
        }
    }
}