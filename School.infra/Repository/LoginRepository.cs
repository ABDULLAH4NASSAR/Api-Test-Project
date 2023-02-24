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
    public class LoginRepository : ILoginRepository
    {
        private readonly IDBContaxt dBContaxt;
        public LoginRepository(IDBContaxt dBContaxt)
        {
            this.dBContaxt = dBContaxt;
        }

            public void DeleteById(int id)
        {
            var p = new DynamicParameters();
            p.Add("login_id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Execute("login.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Login> GetAll()
        {
            var result = dBContaxt.Connection.Query<Login>("login.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Login GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Query<Login>("login.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void Insert(Login login)
        {
            var p = new DynamicParameters();

            p.Add("username", login.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("password", login.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("role_id", login.Role_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("student_id", login.Student_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Execute("login.insertlogin", p, commandType: CommandType.StoredProcedure);


        }

        public void Update(Login login)
        {
            var p = new DynamicParameters();
            p.Add("id", login.Login_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("username", login.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("password", login.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("role_id", login.Role_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("student_id", login.Student_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Execute("login.insertlogin", p, commandType: CommandType.StoredProcedure);
        }
    }
}
