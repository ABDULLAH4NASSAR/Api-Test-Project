using School.Core.Dataa;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Core.Repository
{
    public interface ICourseRepository
    {
        public List<Course> GetAllcousre();
        public Course GetcousreById(int id);
        public void Insertcousre(Course course);
        public void Updatecousre(Course course);
        public void DeletecousreById(int id);
    }
}
