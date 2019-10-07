using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayStation_Shop.Data.Models
{
    public class OrderDetail
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public ushort Price { get; set; }
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }

    }
}
