using Dapper;
using School.Core.Dataa;
using School.Core.Repository;
using School.infra.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace School.infra.Repository
{
    internal class RoleRepository : IRoleRepository
    {
        private readonly DBContaxt dBContaxt;
        public RoleRepository(DBContaxt dBContaxt)
        {
            this.dBContaxt = dBContaxt;
        }



        //PROCEDURE Getbyid(id role_s.role_id%type);
        //PROCEDURE Deletebyid(id role_s.role_id%type);
        //PROCEDURE Getall;
        //PROCEDURE insertrole(rolename role_s.role_name%type);
        //PROCEDURE updaterole(id role_s.role_id%type, rolename role_s.role_name%type);

        //end role;

        public void DeleteById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Execute("role.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Role> GetAll()
        {
            var result = dBContaxt.Connection.Query<Role>("role.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Role GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Query<Role>("role.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void Insert(Role role)
        {
            var p = new DynamicParameters();

            p.Add("username", role.RoleName, dbType: DbType.String, direction: ParameterDirection.Input);
         
            var result = dBContaxt.Connection.Execute("role.insertrole", p, commandType: CommandType.StoredProcedure);


        }

        public void Update(Role role)
        {
            var p = new DynamicParameters();
            p.Add("id", role.Role_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("username", role.RoleName, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dBContaxt.Connection.Execute("role.updaterole", p, commandType: CommandType.StoredProcedure);
        }
    }
}
