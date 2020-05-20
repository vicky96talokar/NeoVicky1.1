using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NeoVicky.Models;
using System.Data.Entity;

namespace NeoVicky.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}