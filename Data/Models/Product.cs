﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayStation_Shop.Data.Models
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string ShortDesc{ get; set; }

        public string LongDesc { get; set; }

        public string Img { get; set; }

        public ushort Price { get; set; }

        public bool IsFavourite { get; set; }

        public bool Available { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { set; get; }

    }

}
