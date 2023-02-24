using School.Core.Dataa;
using School.Core.Repository;
using School.Core.service;
using School.infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.infra.service
{
    public class LoginService: ILoginService
    {
        private readonly ILoginRepository loginRepository;
        public LoginService(ILoginRepository loginRepository)
        {
            this.loginRepository = loginRepository;
        }

        public void DeleteById(int id)
        {
            loginRepository.DeleteById(id);
        }

        public List<Login> GetAll()
        {
            return loginRepository.GetAll();
        }

        public Login GetById(int id)
        {
            return loginRepository.GetById(id);
        }

        public void Insert(Login login)
        {
            loginRepository.Insert(login);
        }

        public void Update(Login login)
        {
            loginRepository.Update(login);
        }
    }
}
