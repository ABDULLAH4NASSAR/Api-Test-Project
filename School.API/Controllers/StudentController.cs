using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Core.Dataa;
using School.Core.DTO;
using School.Core.service;
using System;
using System.Collections.Generic;

namespace School.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly IStudentService studentService;
        public StudentController(IStudentService studentService) 
        {
        this.studentService = studentService;
        
        
        }

        [HttpPost]
        [Route("Searchn")]
        public List<Search> Searchn(Search search) 
        {
        return studentService.Searchn(search);
        
        }



        [HttpGet]
        [Route("DisplayFirstandLastName")]
        public List<Student> DisplayFirstandLastName() { return studentService.DisplayFirstandLastName(); }
        [HttpGet]
        [Route("Displaytop3")]
        public List<nametop3> Displaytop3() { return studentService.Displaytop3(); }
        [HttpGet]
        [Route("DisplayByBerthOfDate/{dateTime}")]
        public List<Student> DisplayByBerthOfDate(DateTime dateTime) { return studentService.DisplayByBerthOfDate(dateTime); }
        [HttpGet]
        [Route("DisplayByBerthOfDateInterval/{datefrom}&{dateto}")]
        public List<Student> DisplayByBerthOfDateInterval(DateTime datefrom, DateTime dateto) { return studentService.DisplayByBerthOfDateInterval(datefrom, dateto); }
        [HttpGet]
        [Route("DisplayByFirstName/{firstname}")]
        public List<Student> DisplayByFirstName(string firstname) { return studentService.DisplayByFirstName(firstname); }
        [HttpGet]
        [Route("GetAll")]
        public List<Student> GetAll() 
        {
            return studentService.GetAllStd();
        
        }
        [HttpGet]
        [Route("GetStdById/{id}")]
        public Student GetStdById(int id)
        {
            return studentService.GetStdById(id); 
        }

        [HttpPost]
        [Route("InsertStd")]
        public void InsertStd(Student student) 
        {
        studentService.InsertStd(student);
        }
        [HttpPut]
        [Route("UpdateStd")]
        public void UpdateStd(Student student) 
        {
        
        studentService.UpdateStd(student);
        }
        [HttpDelete]
        [Route("DeleteStdById/{id}")]
        public void DeleteStdById(int id) 
        {

            studentService.DeleteStdById(id);
        }


    }
}
