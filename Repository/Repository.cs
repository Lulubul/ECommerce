using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess
{
    public class Repository
    {
        private ProductsRepository _productsRepository;
        private readonly ECommerceContext _context;

        public Repository()
        {
            _context = new ECommerceContext();
        }

        public ProductsRepository Products
        {
            get
            {
                return _productsRepository = _productsRepository ?? new ProductsRepository(_context);
            }
            
        }
    }
}
