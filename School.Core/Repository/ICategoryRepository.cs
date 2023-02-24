using School.Core.Dataa;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Core.Repository
{
    public interface ICategoryRepository
    {
        public List<Category> GetAll();
        public Category GetById(int id);
        public void Insert(Category category);
        public void Update(Category category);
        public void DeleteById(int id);
    }
}
