using PlayStation_Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayStation_Shop.Data.Interfaces
{
    public interface IProductsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
