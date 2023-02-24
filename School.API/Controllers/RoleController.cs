using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Core.Dataa;
using School.Core.service;
using System.Collections.Generic;

namespace School.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService roleService;
        public RoleController(IRoleService roleService)
        {
            this.roleService = roleService;
        }
        //public List<Category> GetAll();
        //public Category GetById(int id);
        //public void Insert(Category category);
        //public void Update(Category category);
        //public void DeleteById(int id);

        [HttpGet]
        [Route("getall")]
        public List<Role> GetAll() { return roleService.GetAll(); }

        [HttpGet]
        [Route("GetById/{id}")]
        public Role GetById(int id) { return roleService.GetById(id); }
        [HttpPost]
        [Route("insert")]
        public void Insert(Role role) { roleService.Insert(role); }
        [HttpPut]
        [Route("Update")]
        public void Update(Role role) { roleService.Update(role); }
        [HttpDelete]
        [Route("DeleteById/{id}")]
        public void DeleteById(int id) { roleService.DeleteById(id); }
    }
}
