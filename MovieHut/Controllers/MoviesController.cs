using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieHut.Models;
using MovieHut.ViewModels;

namespace MovieHut.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Lord of the Rings"};

        var customers = new List<Customer>
        {
            new Customer {Name = "Customer 1"},
            new Customer {Name = "Customer 2"}
        };

        var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
    }
    }
}