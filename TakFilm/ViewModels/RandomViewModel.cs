﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TakFilm.Models;

namespace TakFilm.ViewModels
{
    public class RandomViewModel
    {
        public Movie Movie { get; set; }
        public List< Customer> Customers { get; set; }
    }
}