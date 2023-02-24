using School.Core.Dataa;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Core.Repository
{
    public interface IRoleRepository
    {
        public List<Role> GetAll();
        public Role GetById(int id);
        public void Insert(Role role);
        public void Update(Role role);
        public void DeleteById(int id);
    }
}
