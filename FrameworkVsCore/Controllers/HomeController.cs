using DataLibrary.BusinessLogic;
using FrameworkVsCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrameworkVsCore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewBooks()
        {
            var data = BooksProcessor.LoadBooks();
            List<BookModel> books = new List<BookModel>();

            foreach (var row in data)
            {
                books.Add(new BookModel
                {
                    Title = row.Title,
                    Price = row.Price
                });

            }

            return View(books);
        }

        public ActionResult BooksCreate()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BooksCreate(BookModel model)
        {
            if (ModelState.IsValid) 
            {
                BooksProcessor.CreateBook(model.Title,model.Price);
                return View("Index");
            }

            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}