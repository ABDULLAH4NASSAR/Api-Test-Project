using Dapper;
using School.Core.Common;
using School.Core.Dataa;
using School.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace School.infra.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly IDBContaxt db;
        public CourseRepository(IDBContaxt db)
        {
            this.db = db;
        }

        public void DeletecousreById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = db.Connection.Execute("course_package.deleteCourse", p, commandType: CommandType.StoredProcedure);
        }

        public List<Course> GetAllcousre()
        {
            var result = db.Connection.Query<Course>("course_package.GetAllCourse", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Course GetcousreById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = db.Connection.Query<Course>("course_package.GetCourseById", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void Insertcousre(Course course)
        {
            
            var p = new DynamicParameters();
            p.Add("coursename", course.Coursename, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("price", course.Price, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("s_date", course.S_Date, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("e_date", course.E_Date, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("category", course.Caregory_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("image", course.Image, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = db.Connection.Execute("course_package.insertcourse", p, commandType: CommandType.StoredProcedure);
        }

    

        public void Updatecousre(Course course)
        {
            var p = new DynamicParameters();
            p.Add("id",course.Course_Id,dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("coursename1", course.Coursename, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("price1", course.Price, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("s_date1", course.S_Date, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("e_date1", course.E_Date, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("category", course.Caregory_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("image1", course.Image, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = db.Connection.Execute("course_package.UpdateCourse", p, commandType: CommandType.StoredProcedure);
        }

      
    }
}
