using School.Core.Dataa;
using School.Core.DTO;
using School.Core.Repository;
using School.Core.service;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.infra.service
{
    public class StdCourseService : IStdCourseService
    {
        private readonly IStdCourseRepository courseRepository;
        public StdCourseService(IStdCourseRepository courseRepository) 
        {
        this.courseRepository = courseRepository;
        
        }
        public void DeleteById(int id)
        {
            courseRepository.DeleteById(id);
        }

        public List<Stdcourse> GetAll()
        {
            return courseRepository.GetAll();
        }

        public Stdcourse GetById(int id)
        {
            return courseRepository.GetById(id);
        }

        public void InsertStdCourse(Stdcourse stdcourse)
        {
            courseRepository.InsertStdCourse(stdcourse);
        }

        public List<StdCorMark> StdCorMark()
        {
            return courseRepository.StdCorMark();
        }

        public void UpdateStdCourse(Stdcourse stdcourse)
        {
            courseRepository.UpdateStdCourse(stdcourse);
        }
    }
}
