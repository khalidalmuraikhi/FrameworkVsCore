using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public  class BooksProcessor
    {
        public  int CreateBook(string title, int price)
        {
            BookModel data = new BookModel
            {
                Title = title,
                Price = price
            };

            string sql = @"insert into dbo.Books (Title, Price)
                            values (@Title, @Price);";

            return SqlDataAccess.SaveData(sql, data);

        }

        public  List<BookModel> LoadBooks(string connectionString)
        {
            string sql = @"select Id, Title, Price from dbo.Books;";
            return SqlDataAccess.LoadData<BookModel>(sql, connectionString);
        }
    }
}
