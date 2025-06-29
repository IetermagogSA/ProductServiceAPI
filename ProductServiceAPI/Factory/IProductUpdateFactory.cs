using ProductServiceAPI.Enums;
using ProductServiceAPI.Models;
using ProductServiceAPI.Strategy;

namespace ProductServiceAPI.Factory
{
    public interface IProductUpdateStrategyFactory
    {
        public IProductUpdateStrategy GetUpdateStrategy(ProductGroupEnum productGroup);
    }
}
