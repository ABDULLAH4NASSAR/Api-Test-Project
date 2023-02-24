using Dapper;
using Microsoft.EntityFrameworkCore;
using School.Core.Common;
using School.Core.Dataa;
using School.Core.DTO;
using School.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace School.infra.Repository
{
    public class StdCourseRepository : IStdCourseRepository
    {


        private readonly IDBContaxt db;
        public StdCourseRepository(IDBContaxt db) 
        {
            this.db = db;
        
        }


        public void DeleteById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = db.Connection.Execute("coursestd_package.deletecoursestd", p, commandType: CommandType.StoredProcedure);
        }

        public List<Stdcourse> GetAll()
        { 
            var result = db.Connection.Query<Stdcourse>("coursestd_package.GetAllcoursestd", commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public Stdcourse GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = db.Connection.Query<Stdcourse>("coursestd_package.GetcoursestdById", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }
        //PROCEDURE insertcoursestd(STDID in stdcourse_s.STDID%type, COURDEID in stdcourse_s.courdeid%type, MARKOFSTD in stdcourse_s.markofstd%type, DATEOFREGISTER in stdcourse_s.dateofregister%type);

        public void InsertStdCourse(Stdcourse stdcourse)
        {
            var p=new DynamicParameters();
            p.Add("STDID", stdcourse.Stdid, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("COURDEID", stdcourse.Courdeid, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("MARKOFSTD", stdcourse.Markofstd, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("DATEOFREGISTER", stdcourse.Dateofregister, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            var result = db.Connection.Execute("coursestd_package.insertcoursestd", p, commandType: CommandType.StoredProcedure);
        }

        public List<StdCorMark> StdCorMark()
        {
            var result = db.Connection.Query<StdCorMark>("coursestd_package.stdcormark", commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public void UpdateStdCourse(Stdcourse stdcourse)
        {
            var p = new DynamicParameters();
            p.Add("id1", stdcourse.Id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("STDID1", stdcourse.Stdid, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("COURDEID1", stdcourse.Courdeid, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("MARKOFSTD1", stdcourse.Markofstd, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("DATEOFREGISTER1", stdcourse.Dateofregister, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            var result = db.Connection.Execute("coursestd_package.Updatecoursestd", p, commandType: CommandType.StoredProcedure);
        }

       
    }
}
