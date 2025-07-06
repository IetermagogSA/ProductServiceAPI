using ProductServiceAPI.Enums;
using ProductServiceAPI.Strategy;

namespace ProductServiceAPI.Factory
{
    public interface IProductSortingStrategyFactory
    {
        public IProductSortingStrategy GetStrategy(ProductStatusEnum productStatus);
    }
}
