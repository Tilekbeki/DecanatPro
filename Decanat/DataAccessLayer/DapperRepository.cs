using Dapper;
using Model2;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DataAccessLayer
{
    public class DapperRepository<T> : IRepository<T> where T : class, IDomainObject
    {
        static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DbConnection;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        IDbConnection db = new SqlConnection(connectionString);
        public IEnumerable<T> GetAll()
        {
            return db.Query<T>("SELECT * FROM Students").ToList();
        }
        public void Create(T t)
        {
            var sqlQuery = "INSERT INTO Students (Name, [Group], Speciality) VALUES(@Name, @Group, @Speciality); SELECT CAST(SCOPE_IDENTITY() as int)";
            int Id = db.Query<int>(sqlQuery, t).FirstOrDefault();
            t.Id = Id;
        }
        public void Save() { }
        public void Delete(int list_number)
        {
            int id = list_number;
            var sqlQuery = "DELETE FROM Students WHERE Id = @id";
            db.Execute(sqlQuery, new { id });
        }
        public T FindForIndex(int index)
        {
            return null;
        }
    }
}
