using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class BooksProcessor
    {
        public static int CreateBook(string title, int price)
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

        public static List<BookModel> LoadBooks()
        {
            string sql = @"select Id, Title, Price from dbo.Books;";
            return SqlDataAccess.LoadData<BookModel>(sql);
        }
    }
}
