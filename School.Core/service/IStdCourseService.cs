using School.Core.Dataa;
using School.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Core.service
{
    public interface IStdCourseService
    {
        public List<Stdcourse> GetAll();
        public void DeleteById(int id);
        public void InsertStdCourse(Stdcourse stdcourse);
        public void UpdateStdCourse(Stdcourse stdcourse);
        public Stdcourse GetById(int id);

        public List<StdCorMark> StdCorMark();
    }
}
