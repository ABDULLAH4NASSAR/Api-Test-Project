using School.Core.Dataa;
using School.Core.DTO;
using School.Core.Repository;
using School.Core.service;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.infra.service
{
    public class StudentService: IStudentService
    {
        private readonly IStudentRepository studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public void DeleteStdById(int id)
        {
            studentRepository.DeleteStdById(id);
        }

        public List<Student> DisplayByBerthOfDate(DateTime dateTime)
        {
            return studentRepository.DisplayByBerthOfDate(dateTime);
        }

        public List<Student> DisplayByBerthOfDateInterval(DateTime datefrom, DateTime dateto)
        {
            return studentRepository.DisplayByBerthOfDateInterval(datefrom, dateto);
        }

        public List<Student> DisplayByFirstName(string firstname)
        {
            return studentRepository.DisplayByFirstName(firstname);
        }

        public List<Student> DisplayFirstandLastName()
        {
            return studentRepository.DisplayFirstandLastName();
        }

        public List<nametop3> Displaytop3()
        {
            return studentRepository.Displaytop3();
        }

        public List<Student> GetAllStd()
        {
        return studentRepository.GetAllStd();
        }

        public Student GetStdById(int id)
        {
            return studentRepository.GetStdById(id);
        }

        public void InsertStd(Student student)
        {
             studentRepository.InsertStd(student);
        }

        public List<Search> Searchn(Search search)
        {
            return studentRepository.Searchn(search);
        }

        public void UpdateStd(Student student)
        {
             studentRepository.UpdateStd(student);
        }
    }
}
