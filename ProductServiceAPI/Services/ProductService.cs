using ProductServiceAPI.Factory;
using ProductServiceAPI.Models;
using ProductServiceAPI.Strategy;

namespace ProductServiceAPI.Services
{
    public class ProductService : IProductService
    {
        private IProductCreateStrategy _productCreateStrategy;
        private IProductUpdateStrategy _productUpdateStrategy;
        private IProductSortingStrategy _productSortingStrategy;

        private readonly IProductCreateStrategyFactory _productCreateStrategyFactory;
        private readonly IProductUpdateStrategyFactory _productUpdateStrategyFactory;
        private readonly IProductSortingStrategyFactory _productSortingStrategyFactory;

        public ProductService(IProductCreateStrategyFactory productCreateStrategyFactory, 
            IProductUpdateStrategyFactory productUpdateStrategyFactory,
            IProductSortingStrategyFactory productSortingStrategyFactory)
        {
            _productCreateStrategyFactory = productCreateStrategyFactory;
            _productUpdateStrategyFactory = productUpdateStrategyFactory;
            _productSortingStrategyFactory = productSortingStrategyFactory;
        }
        public Product Create(Product product)
        {
            _productCreateStrategy = _productCreateStrategyFactory.GetStrategy(product.Group);
            _productSortingStrategy = _productSortingStrategyFactory.GetStrategy(product.Status);
            product.Options = _productSortingStrategy.SortOptions(product.Options);

            return _productCreateStrategy.CreateProduct(product);
        }

        public Product Update(Product product)
        {
            _productUpdateStrategy = _productUpdateStrategyFactory.GetUpdateStrategy(product.Group);
            _productSortingStrategy = _productSortingStrategyFactory.GetStrategy(product.Status);
            product.Options = _productSortingStrategy.SortOptions(product.Options);

            return _productUpdateStrategy.UpdateProduct(product);
        }
    }
}
