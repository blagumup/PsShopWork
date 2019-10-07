using PlayStation_Shop.Data.Interfaces;
using PlayStation_Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayStation_Shop.Data.Mocks
{
    public class MockCategory : IProductsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "Консоли", Desc = "Игровая Консоль"},
                    new Category { CategoryName = "Аксессуары", Desc = "Аксессуары для приставок"},
                    new Category { CategoryName = "Игры", Desc = "Консольные игры"}
                };
            }
        }
    }
}
