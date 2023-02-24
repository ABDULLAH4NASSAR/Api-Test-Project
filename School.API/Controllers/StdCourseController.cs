using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Core.Dataa;
using School.Core.DTO;
using School.Core.service;
using System.Collections.Generic;

namespace School.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StdCourseController : ControllerBase
    {
        private readonly IStdCourseService stdCourseService;
        public StdCourseController(IStdCourseService stdCourseService) 
        {
        this.stdCourseService = stdCourseService;
        
        }
        [HttpGet]
        [Route("GetAll")]
        public List<Stdcourse> GetAll()
        {
            return stdCourseService.GetAll();
        }

        [HttpGet]
        [Route("StdCorMark")]
        public List<StdCorMark> StdCorMark()
        {
            return stdCourseService.StdCorMark();
        }


    }
}
