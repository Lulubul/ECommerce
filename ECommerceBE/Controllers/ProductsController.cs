using System.Collections.Generic;
using System.Web.Http;
using DataAccess;
using Entities;

namespace ECommerce.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly Repository _repository;
        private readonly ProductsRepository _productsRepository;

        public ProductsController()
        {
            _repository = new Repository();
            _productsRepository = _repository.Products;
        }

        public IEnumerable<Product> Get()
        {
            return _productsRepository.GetProducts();
        }

    }
}
