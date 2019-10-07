using Microsoft.AspNetCore.Mvc;
using PlayStation_Shop.Data.Interfaces;
using PlayStation_Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayStation_Shop.Controllers
{
    public class HomeController : Controller
    {
        private IAllProducts _productRepository;
        
        public HomeController(IAllProducts productRepository)
        {
            _productRepository = productRepository;
        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                FavProducts = _productRepository.GetFavProducts
            };
            return View(homeCars);
        }
    }
}
