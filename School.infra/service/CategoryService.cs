using School.Core.Dataa;
using School.Core.Repository;
using School.Core.service;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.infra.service
{
    public class CategoryService : ICategoryService
    {

        private readonly ICategoryRepository categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public void DeleteById(int id)
        {
            categoryRepository.DeleteById(id);
        }

        public List<Category> GetAll()
        {
        return categoryRepository.GetAll();
                }

        public Category GetById(int id)
        {
            return categoryRepository.GetById(id);
        }

        public void Insert(Category category)
        {
            categoryRepository.Insert(category);
        }

        public void Update(Category category)
        {
            categoryRepository.Update(category);
        }
    }
}
