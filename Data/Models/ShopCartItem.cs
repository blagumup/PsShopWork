using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayStation_Shop.Data.Models
{
    public class ShopCartItem
    {
        public Guid Id { get; set; }
        public Product Product { get; set; }
        public ushort Price { get; set; }

        public string ShopCartId { get; set; }
    }
}
