using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CatsWebsite.Controllers
{
    public class HomeController : Controller
    {
        public const int LASTCOMIC = 10;

        public ActionResult Index()
        {
            ViewBag.LastComic = LASTCOMIC;
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Archive()
        {
            ViewBag.LastComic = LASTCOMIC;
            return View();
        }

        public ActionResult Comic(int id)
        {
            ViewBag.LastComic = LASTCOMIC;
            ViewBag.ComicNumber = id;
            return View();
        }
    }
}