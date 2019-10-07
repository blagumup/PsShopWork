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
    public class ShopCartController : Controller
    {
        private IAllProducts _productRepository;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllProducts productRepository, ShopCart shopCart)
        {
            _productRepository = productRepository;
            _shopCart = shopCart;
        }

        public ViewResult Index() // возвращает определенный шаблон
        {
            var items = _shopCart.GetShopItems();
            _shopCart.ListShopItems = items;

            var obj = new ShopCartViewModel
            {
                ShopCart = _shopCart
            };

            return View(obj);
        }

        //Добавляет товары в корзину и Переадресовывает на другую страницу
        public RedirectToActionResult AddToCart(Guid id)
        {
            var item = _productRepository.Products.FirstOrDefault(i => i.Id == id);
            if(item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }

    }
}
