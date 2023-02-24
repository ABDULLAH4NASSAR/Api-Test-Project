using School.Core.Dataa;
using School.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Core.Repository
{
    public interface IStudentRepository { 
    //{
    //    PROCEDURE GetAllSTUDENT;
    //    PROCEDURE GetSTUDENTById(id in STUDENT_S.student_id%type);
    //    PROCEDURE deleteSTUDENT(id in STUDENT_S.student_id%type);
    //    PROCEDURE DisplayFirstandLastName;
    //    PROCEDURE Displaytop3;

    //    PROCEDURE DisplayByBerthOfDate(datee student_s.dateofbirth%type);
    //    PROCEDURE DisplayByBerthOfDateInterval(datefrom student_s.dateofbirth%type, dateto student_s.dateofbirth%type);

    //    PROCEDURE DisplayByFirstName(firstname1 student_s.firstname%type);
    //    PROCEDURE UpdateSTUDENT(id in STUDENT_S.student_id%type, FIRSTNAME1 IN STUDENT_S.firstname%TYPE, LASTNAME1 IN STUDENT_S.lastname%TYPE, DATEOFBIRTH1 IN STUDENT_S.dateofbirth%TYPE);
    //    PROCEDURE insertSTUDENT(FIRSTNAME IN STUDENT_S.firstname%TYPE, LASTNAME IN STUDENT_S.lastname%TYPE, DATEOFBIRTH IN STUDENT_S.dateofbirth%TYPE);
        public List<Student> GetAllStd();
        public List<Student> DisplayFirstandLastName();
        public List<nametop3> Displaytop3();
        public List<Student> DisplayByBerthOfDate(DateTime dateTime);
        public List<Student> DisplayByBerthOfDateInterval(DateTime datefrom,DateTime dateto);
        public List<Student> DisplayByFirstName(string firstname);

        public List<Search> Searchn(Search search);



        public Student GetStdById(int id);
        public void InsertStd(Student student);
        public void UpdateStd(Student student);
        public void DeleteStdById(int id);
        
    }
}
