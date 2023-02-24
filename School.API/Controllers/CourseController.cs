using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Core.Dataa;
using School.Core.service;
using System.Collections.Generic;

namespace School.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService courseService;
        public CourseController(ICourseService courseService) 
        {
            this.courseService = courseService;
        
        }
        [HttpGet]
        [Route("GetAllcousre")]
        public List<Course> GetAllcousre() { return courseService.GetAllcousre(); }
        [HttpGet]
        [Route("GetcousreById/{id}")]
        public Course GetcousreById(int id) { return courseService.GetcousreById(id); }
        [HttpPost]
        [Route("Insertcousre")]
        public void Insertcousre(Course course) { courseService.Insertcousre(course); }
        [HttpPut]
        [Route("Updatecousre")]
        public void Updatecousre(Course course) { courseService.Updatecousre(course); }
        [HttpDelete]
        [Route("DeletecousreById/{id}")]
        public void DeletecousreById(int id) { courseService.DeletecousreById(id); }



    }
}
