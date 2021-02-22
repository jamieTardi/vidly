using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly1.Models;

namespace vidly1.Controllers
{
    public class MoviesController : Controller
    {
         
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek"};

            return View(movie);
            //return Content("Hello World");
            //return HttpNotFound();
            //return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name"});
        }

        public ActionResult byReleaseDate(int year, byte month)
        {
            return Content(year + "/" + month);
        }

        //adding the genere result
        public ActionResult byGenere(string genere)
        {
            return Content(genere);
        }
        public ActionResult Edit(int Id)
        {
            return Content("<h1>ID=</h1>" + Id);
        }

        //movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
    }
}