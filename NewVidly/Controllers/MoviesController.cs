using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewVidly.Models;
using NewVidly.ViewModels;

namespace NewVidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var mList = new List<Movie>
            {
                new Movie { Id = 1, Name = "Pulp Fiction" },
                new Movie { Id = 2, Name = "Django" }
            };

            var viewModel = new MoviesCustomers
            {
                movieList = mList,
                customerList = new List<Customer>()
            };

            return View(viewModel);
        }

        [Route("/movies/detail/{id}")]
        public ActionResult Detail(int id)
        {
            int number = 0;
            string name = "";

            if (id == 1)
            {
                number = 1;
                name = "Pulp Fiction";
            }
            else if (id == 2)
            {
                number = 2;
                name = "Django";
            }

            var movie = new Movie
            {
                Id = number,
                Name = name
            };

            return View(movie);
        }




    }
}