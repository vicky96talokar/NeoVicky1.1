using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NeoVicky.Models;
using NeoVicky.ViewModels;

namespace NeoVicky.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Matrix" };

            var customers = new List<Customer>
            {
                new Customer { Name="Customer 1"},
                new Customer { Name="Customer 2"},
                new Customer { Name="Customer 3"},
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
             
            return View(viewModel);
        }

        public ViewResult Details()
        {
            Movie  model = new Movie() { Name = "Matrix" };
            ViewBag.PageTitle = "Welcome To MVC Site";
            return View(model);
        }

    }
}