using ProjetoModel.Domain.Entities;
using ProjetoModel.Domain.Interfaces.Repository;
using System.Collections.Generic;

namespace ProjetoModel.Domain.Services
{
    public class ProductService : ServiceBase<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository) : 
            base(productRepository)
        {
            _productRepository = productRepository;
        }
        public IEnumerable<Product> FindByName(string nome)
        {
            return _productRepository.FindByName(nome);
        }
    }
}
