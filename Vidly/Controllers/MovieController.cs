using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var movie = new Movie() { Name="mohamed"};
            var customers = new List<Customer>
           {
               new Customer {Name="Customer 1" },
               new Customer {Name="Customer 2" }
           };

            var movieViewModel = new MovieViewModel
            {
                Movie = movie,
                Customer = customers
            };
            return View(movieViewModel);

        }
        [Route("Movie/Release/{year}/{month:regex(\\d{4})}")]
        public ActionResult ByReleaseDate(int year,int month)
        {
            return Content(year + "/" + month);

        }
    }
}