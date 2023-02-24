using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using School.Core.Dataa;
using School.Core.service;
using System.Collections.Generic;

namespace School.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        //public List<Category> GetAll();
        //public Category GetById(int id);
        //public void Insert(Category category);
        //public void Update(Category category);
        //public void DeleteById(int id);

        [HttpGet]
        [Route("getall")]
        public List<Category> GetAll() { return _categoryService.GetAll(); }

        [HttpGet]
        [Route("GetById/{id}")]
        public Category GetById(int id) { return _categoryService.GetById(id); }
        [HttpPost]
        [Route("insert")]
        public void Insert(Category category) { _categoryService.Insert(category); }
        [HttpPut]
        [Route("Update")]
        public void Update(Category category) { _categoryService.Update(category); }
        [HttpDelete]
        [Route("DeleteById/{id}")]
        public void DeleteById(int id) { _categoryService.DeleteById(id); }
    }
}
