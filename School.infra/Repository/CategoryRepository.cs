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
    public class CategoryRepository : ICategoryRepository
    {

        private readonly IDBContaxt dBContaxt;
        public CategoryRepository(IDBContaxt dBContaxt)
        {
            this.dBContaxt = dBContaxt;
        }
        public void DeleteById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Execute("category_package.Deletebyid", p, commandType: CommandType.StoredProcedure);
        }

        public List<Category> GetAll()
        {
            var result = dBContaxt.Connection.Query<Category>("category_package.Getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Category GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Query<Category>("category_package.Getbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void Insert(Category category)
        {
            var p = new DynamicParameters();

            p.Add("catname", category.CategoryName, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Execute("category_package.insertcategory", p, commandType: CommandType.StoredProcedure);


        }

        public void Update(Category category)
        {
            var p = new DynamicParameters();
            p.Add("id1", category.Category_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("catname", category.CategoryName, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dBContaxt.Connection.Execute("category_package.insertcategory", p, commandType: CommandType.StoredProcedure);
        }
    }
}
