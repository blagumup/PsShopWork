using Microsoft.AspNetCore.Mvc;
using PlayStation_Shop.Data.Interfaces;
using PlayStation_Shop.Data.Models;
using PlayStation_Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayStation_Shop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IAllProducts _allProducts;
        private readonly IProductsCategory _allCategories;


        public ProductsController(IAllProducts iAllProducts, IProductsCategory iProductsCat)
        {
            _allProducts = iAllProducts;
            _allCategories = iProductsCat;
        }

        [Route("Products/List")]
        [Route("Products/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Product> products = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
                products = _allProducts.Products.OrderBy(i => i.Price);

            else if (string.Equals("consoles", category, StringComparison.OrdinalIgnoreCase))
            {
                products = _allProducts.Products.Where(i => i.Category.CategoryName.Equals("Консоли")).OrderBy(i => i.Price);
                currCategory = "Консоли";
            }
            else if (string.Equals("accessories", category, StringComparison.OrdinalIgnoreCase))
            {
                products = _allProducts.Products.Where(i => i.Category.CategoryName.Equals("Аксессуары")).OrderBy(i => i.Price);
                currCategory = "Аксессуары";
            }

            else if (string.Equals("games", category, StringComparison.OrdinalIgnoreCase))
            {
                products = _allProducts.Products.Where(i => i.Category.CategoryName.Equals("Игры")).OrderBy(i => i.Price);
                currCategory = "Игры";
            }

           

            var productObj = new ProductsListViewModel
            {
                AllProducts = products,
                CurrCategory = currCategory
            };

            ViewBag.Title = "Страница с товарами";
            
            return View(productObj);
        }
    }
}
