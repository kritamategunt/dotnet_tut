using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;

namespace helloWorld.Data
{
    public class DataContextDapper
    {

        private readonly string _connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=True;Trusted_Connection=false;User Id=sa;Password=SQLConnect1!;";

        public IEnumerable<T> LoadData<T>(string sql)
        {
            IDbConnection dbConnection = new SqlConnection(_connectionString);
            return dbConnection.Query<T>(sql);
        }
        public T LoadDataSingle<T>(string sql)
        {
            IDbConnection dbConnection = new SqlConnection(_connectionString);
            return dbConnection.QuerySingle<T>(sql);
        }
        public bool ExecuteCommand<T>(string sql)
        {
            IDbConnection dbConnection = new SqlConnection(_connectionString);
            return (dbConnection.Execute(sql) > 0);
        }

        public int ExecuteSqlWithRowCount<T>(string sql)
        {
            IDbConnection dbConnection = new SqlConnection(_connectionString);
            Console.WriteLine("Affect on "+dbConnection.Execute(sql)+" rows");
            return dbConnection.Execute(sql);
        }
    }
}