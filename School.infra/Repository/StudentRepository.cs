using Dapper;
using School.Core.Common;
using School.Core.Dataa;
using School.Core.DTO;
using School.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace School.infra.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IDBContaxt db;
        public StudentRepository(IDBContaxt dBContaxt) 
        {
              db = dBContaxt;
        }

        public void DeleteStdById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id",id,dbType:DbType.Int32,direction:ParameterDirection.Input);
            var result = db.Connection.Execute("STUDENT_PACKAGE.deleteSTUDENT", p, commandType: CommandType.StoredProcedure);
        }

        public List<Student> DisplayByBerthOfDate(DateTime dateTime)
        {
            var p = new DynamicParameters();
            p.Add("datee", dateTime, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            var result = db.Connection.Query<Student>("STUDENT_package.DisplayByBerthOfDate", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
//        create or replace PACKAGE STUDENT_package
//as
//PROCEDURE GetAllSTUDENT;
//        PROCEDURE GetSTUDENTById(id in STUDENT_S.student_id%type);
//        PROCEDURE deleteSTUDENT(id in STUDENT_S.student_id%type);
//        PROCEDURE DisplayFirstandLastName;
//        PROCEDURE Displaytop3;

//        PROCEDURE DisplayByBerthOfDate(datee student_s.dateofbirth%type);
//        PROCEDURE DisplayByBerthOfDateInterval(datefrom student_s.dateofbirth%type, dateto student_s.dateofbirth%type);

//        PROCEDURE DisplayByFirstName(firstname1 student_s.firstname%type);
//        PROCEDURE UpdateSTUDENT(id in STUDENT_S.student_id%type, FIRSTNAME1 IN STUDENT_S.firstname%TYPE, LASTNAME1 IN STUDENT_S.lastname%TYPE, DATEOFBIRTH1 IN STUDENT_S.dateofbirth%TYPE);
//        PROCEDURE insertSTUDENT(FIRSTNAME IN STUDENT_S.firstname%TYPE, LASTNAME IN STUDENT_S.lastname%TYPE, DATEOFBIRTH IN STUDENT_S.dateofbirth%TYPE);
//        end STUDENT_package;
        public List<Student> DisplayByBerthOfDateInterval(DateTime datefrom, DateTime dateto)
        {
            var p =new DynamicParameters();
            p.Add("datefrom", datefrom, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("dateto", dateto, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            var result = db.Connection.Query<Student>("STUDENT_package.DisplayByBerthOfDateInterval", p, commandType: CommandType.StoredProcedure);
            return result.ToList();

        }

        public List<Student> DisplayByFirstName(string firstname)
        {
            var p = new DynamicParameters();
            p.Add("firstname1", firstname, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = db.Connection.Query<Student>("STUDENT_package.DisplayByFirstName", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Student> DisplayFirstandLastName()
        {
            var result = db.Connection.Query<Student>("STUDENT_package.DisplayFirstandLastName", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<nametop3> Displaytop3()
        {
            var result = db.Connection.Query<nametop3>("STUDENT_package.Displaytop3", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Student> GetAllStd()
        {
            var result = db.Connection.Query<Student>("STUDENT_PACKAGE.GetAllSTUDENT", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public Student GetStdById(int id) 
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = db.Connection.Query<Student>("STUDENT_PACKAGE.GetSTUDENTById",p,commandType:CommandType.StoredProcedure);
            return result.FirstOrDefault();
        
        
        }

        public void InsertStd(Student student)
        {
            var p =new DynamicParameters();
            p.Add("FIRSTNAME",student.Firstname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LASTNAME",student.Lastname,dbType:DbType.String, direction: ParameterDirection.Input);
            p.Add("DATEOFBIRTH", student.Dateofbirth, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            var result = db.Connection.Execute("STUDENT_PACKAGE.insertSTUDENT", p, commandType: CommandType.StoredProcedure);
            
        }

        public List<Search> Searchn(Search search)
        {
            var p = new DynamicParameters();
            p.Add("sname",search.firstname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("cname", search.coursename, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("datefrom", search.datefrom, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("dateto", search.dateto, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            var result = db.Connection.Query<Search>("STUDENT_PACKAGE.Searchn", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public void UpdateStd(Student student)
        {
            var p =new DynamicParameters();
            p.Add("id", student.Student_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("FIRSTNAME1", student.Firstname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LASTNAME1", student.Lastname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("DATEOFBIRTH1", student.Dateofbirth, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            var result = db.Connection.Execute("STUDENT_PACKAGE.UpdateSTUDENT", p, commandType: CommandType.StoredProcedure);
        }
    }
}
