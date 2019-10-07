using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayStation_Shop.Data.Models
{
    public class ShopCart
    {
        private readonly AppDBContent appDBContent;

        public ShopCart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public string ShopCartId { get; set; }
        public List<ShopCartItem> ListShopItems { get; set; }

        public static ShopCart GetCart(IServiceProvider services) //Проверка на наличие добавляемого товара в корзине
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session; //Создаем объект, при помощи которого мы сможем работать с сессиями
            var context = services.GetService<AppDBContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", shopCartId);

            return new ShopCart(context) { ShopCartId = shopCartId };
        }

        public void AddToCart(Product product) //Добавление товара в корзину
        {
            appDBContent.ShopCartItem.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                Product = product,
                Price = product.Price
            });

            appDBContent.SaveChanges();
        }

        public List<ShopCartItem> GetShopItems()   // Отображает все товары в корзине
        {
            return appDBContent.ShopCartItem.Where(p => p.ShopCartId == ShopCartId).Include(p => p.Product).ToList();
        } 
    }
}
