using School.Core.Dataa;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Core.service
{
    public interface ICategoryService
    {
        public List<Category> GetAll();
        public Category GetById(int id);
        public void Insert(Category category);
        public void Update(Category category);
        public void DeleteById(int id);
    }
}
