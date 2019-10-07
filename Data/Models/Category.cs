﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayStation_Shop.Data.Models
{
    public class Category
    {
        public Guid Id { get; set; }

        public string CategoryName { get; set; }

        public string Desc { get; set; }

        public List<Product> Products { get; set; }
    }
}
