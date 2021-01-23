using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataLibrary.DataAccess
{
    public  class SqlDataAccess
    {


        public  List<T> LoadData<T>(string sql, string connectionString) 
        {
            using (IDbConnection cnn = new SqlConnection(connectionString))
            {
                List<T> rows = cnn.Query<T>(sql).ToList();
                return rows;
            }
            
        }

        public void SaveData<T>(string sql, T data, string connectionString)
        {
            using (IDbConnection cnn = new SqlConnection(connectionString)) 
            {
                cnn.Execute(sql, data);

            }
        }
    }
}
