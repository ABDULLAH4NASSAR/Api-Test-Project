using School.Core.Dataa;
using School.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Core.service
{
    public interface IStudentService
    {
        public List<Student> GetAllStd();
        public List<Search> Searchn(Search search);
        public Student GetStdById(int id);
        public void InsertStd(Student student);
        public void UpdateStd(Student student);
        public void DeleteStdById(int id);
        public List<Student> DisplayFirstandLastName();
        public List<nametop3> Displaytop3();
        public List<Student> DisplayByBerthOfDate(DateTime dateTime);
        public List<Student> DisplayByBerthOfDateInterval(DateTime datefrom, DateTime dateto);
        public List<Student> DisplayByFirstName(string firstname);
    }
}
