using Microsoft.EntityFrameworkCore;
using PlayStation_Shop.Data.Interfaces;
using PlayStation_Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayStation_Shop.Data.Repository
{
    public class ProductRepository : IAllProducts
    {

        private readonly AppDBContent appDBContent;

        public ProductRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Product> Products => appDBContent.Product.Include(c => c.Category);

        public IEnumerable<Product> GetFavProducts => appDBContent.Product.Where(p => p.IsFavourite).Include(c => c.Category);

        public Product GetObjectProduct(Guid productId) => appDBContent.Product.FirstOrDefault(p => p.Id == productId);
    }
}
