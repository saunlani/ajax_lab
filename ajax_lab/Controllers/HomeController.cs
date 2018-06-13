using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ajax_lab.Models;

namespace ajax_lab.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search()
        {
            return View();
        }

        //combining author an
        [HttpPost]
        public ActionResult GetBooksByAuthor(string author)
        {
            Library2Entities db = new Library2Entities();

            List<book> list = db.books
                .Where(c => c.Author.Contains(author)).ToList();

            return Json(list);
        }


        [HttpPost]
        public ActionResult GetBooksByTitle(string title)
        {
            Library2Entities db = new Library2Entities();

            List<book> list = db.books.Where(
               c => c.Title.Contains(title)
                ).ToList();

            return Json(list);
        }

        public ActionResult TitleSearch()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetBooksByYear(int ?year)
        {
            Library2Entities db = new Library2Entities();

            List<book> list = db.books.Where(
               c => c.YearPublished == (year)
                ).ToList();

            return Json(list);
        }

        public ActionResult YearSearch()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetBooksByPublisher(string publisher)
        {
            Library2Entities db = new Library2Entities();

            List<book> list = db.books.Where(
               c => c.Publisher.Contains(publisher)
                ).ToList();

            return Json(list);
        }

        public ActionResult PublisherSearch()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetBooksByGenre(string genre)
        {
            Library2Entities db = new Library2Entities();

            List<book> list = db.books.Where(
               c => c.Genre.Contains(genre)
                ).ToList();

            return Json(list);
        }

        public ActionResult GenreSearch()
        {
            return View();
        }
    }
}