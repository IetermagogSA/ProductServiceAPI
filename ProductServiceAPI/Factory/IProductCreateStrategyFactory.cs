using ProductServiceAPI.Enums;
using ProductServiceAPI.Strategy;

namespace ProductServiceAPI.Factory
{
    public interface IProductCreateStrategyFactory
    {
        public IProductCreateStrategy GetStrategy(ProductGroupEnum productGroup);
    }
}
