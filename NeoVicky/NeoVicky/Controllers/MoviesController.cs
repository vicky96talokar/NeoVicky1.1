using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NeoVicky.Models;

namespace NeoVicky.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Matrix"
            };
            //return View(movie);
            //return Content("Hello World");
            //return HttpNotFound();
            // return new EmptyResult();
            return RedirectToAction("Index","Home",new { page=1,sortBy = "name"});
        }
    }
}