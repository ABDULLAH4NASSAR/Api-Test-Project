using School.Core.Dataa;
using School.Core.Repository;
using School.Core.service;
using School.infra.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.infra.service
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository roleRepository;
        public RoleService(IRoleRepository roleRepository)
        {
            this.roleRepository = roleRepository;
        }

        public void DeleteById(int id)
        {
            roleRepository.DeleteById(id);
        }

        public List<Role> GetAll()
        {
            return roleRepository.GetAll();
        }

        public Role GetById(int id)
        {
            return roleRepository.GetById(id);
        }

        public void Insert(Role role)
        {
            roleRepository.Insert(role);
        }

        public void Update(Role role)
        {
            roleRepository.Update(role);
        }
    }
}
