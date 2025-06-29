using ProductServiceAPI.Factory;
using ProductServiceAPI.Models;
using ProductServiceAPI.Strategy;

namespace ProductServiceAPI.Services
{
    public class ProductService : IProductService
    {
        private IProductCreateStrategy _productCreateStrategy;
        private IProductUpdateStrategy _productUpdateStrategy;
        private readonly IProductCreateStrategyFactory _productCreateStrategyFactory;
        private readonly IProductUpdateStrategyFactory _productUpdateStrategyFactory;

        public ProductService(IProductCreateStrategyFactory productCreateStrategyFactory, 
            IProductUpdateStrategyFactory productUpdateStrategyFactory)
        {
            _productCreateStrategyFactory = productCreateStrategyFactory;
            _productUpdateStrategyFactory = productUpdateStrategyFactory;
        }
        public Product Create(Product product)
        {
            _productCreateStrategy = _productCreateStrategyFactory.GetStrategy(product.Group);
            return _productCreateStrategy.CreateProduct(product);
        }

        public Product Update(Product product)
        {
            _productUpdateStrategy = _productUpdateStrategyFactory.GetUpdateStrategy(product.Group);
            return _productUpdateStrategy.UpdateProduct(product);
        }
    }
}
