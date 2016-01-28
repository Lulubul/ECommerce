using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess
{
    public class ProductsRepository
    {
        private readonly ECommerceContext _context;

        public ProductsRepository(ECommerceContext eContext)
        {
            _context = eContext;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products;
        }
    }
}
