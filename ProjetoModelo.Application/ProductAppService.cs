using ProjetoModel.Domain.Entities;
using ProjetoModel.Domain.Services;
using ProjetoModelo.Application.Interface;
using System.Collections.Generic;

namespace ProjetoModelo.Application
{
    public class ProductAppService : AppServiceBase<Product>, IProductAppService
    {
        private readonly IProductService _productService;

        public ProductAppService(IProductService productService):
            base(productService)
        {
            this._productService = productService;
        }


        public IEnumerable<Product> FindByName(string nome)
        {
            return _productService.FindByName(nome);
        }

    
    }
}
