﻿using PlayStation_Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayStation_Shop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> FavProducts { get; set; }
    }
}
