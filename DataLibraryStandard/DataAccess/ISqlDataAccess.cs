using System.Collections.Generic;

namespace DataLibrary.DataAccess
{
    public interface ISqlDataAccess
    {
        List<T> LoadData<T>(string sql, string connectionString);
        void SaveData<T>(string sql, T data, string connectionString);
    }
}