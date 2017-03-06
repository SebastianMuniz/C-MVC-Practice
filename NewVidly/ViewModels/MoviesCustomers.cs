using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NewVidly.Models;

namespace NewVidly.ViewModels
{
    public class MoviesCustomers
    {
        public List<Movie> movieList { get; set; }
        public List<Customer> customerList { get; set; }
    }
}