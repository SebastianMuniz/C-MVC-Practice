using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewVidly.Models;
using NewVidly.ViewModels;

namespace NewVidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var cliList = new List<Customer>
            {
                new Customer { Id = 1, Name = "Gonzalo" },
                new Customer { Id = 2, Name = "Sebastian" }
            };

            var viewModel = new MoviesCustomers
            {
                movieList = new List<Movie>(),
                customerList = cliList
            };

            return View(viewModel);
        }
    }
}