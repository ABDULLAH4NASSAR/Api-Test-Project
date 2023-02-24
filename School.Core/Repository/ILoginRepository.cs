using School.Core.Dataa;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Core.Repository
{
    public interface ILoginRepository
    {
        public List<Login> GetAll();
        public Login GetById(int id);
        public void Insert(Login login);
        public void Update(Login login);
        public void DeleteById(int id);
    }
}
