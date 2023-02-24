using School.Core.Dataa;
using School.Core.Repository;
using School.Core.service;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.infra.service
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository courseRepository;
        public CourseService(ICourseRepository _courseRepository)
        {
            courseRepository = _courseRepository;
        }
        public void DeletecousreById(int id)
        {
            courseRepository.DeletecousreById(id);
        }

        public List<Course> GetAllcousre()
        {
            return courseRepository.GetAllcousre();
        }

        public Course GetcousreById(int id)
        {
            return courseRepository.GetcousreById(id);
        }

        public void Insertcousre(Course course)
        {
            courseRepository.Insertcousre(course);
        }

        public void Updatecousre(Course course)
        {
            courseRepository.Updatecousre(course);
        }
    }
}
