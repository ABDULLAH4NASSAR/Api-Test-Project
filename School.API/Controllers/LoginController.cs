using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Core.Dataa;
using School.Core.service;
using System.Collections.Generic;

namespace School.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService loginService;
        public LoginController(ILoginService loginService)
        {
            this.loginService = loginService;
        }
        //public List<Category> GetAll();
        //public Category GetById(int id);
        //public void Insert(Category category);
        //public void Update(Category category);
        //public void DeleteById(int id);

        [HttpGet]
        [Route("getall")]
        public List<Login> GetAll() { return loginService.GetAll(); }

        [HttpGet]
        [Route("GetById/{id}")]
        public Login GetById(int id) { return loginService.GetById(id); }
        [HttpPost]
        [Route("insert")]
        public void Insert(Login login) { loginService.Insert(login); }
        [HttpPut]
        [Route("Update")]
        public void Update(Login login) { loginService.Update(login); }
        [HttpDelete]
        [Route("DeleteById/{id}")]
        public void DeleteById(int id) { loginService.DeleteById(id); }
    }
}
