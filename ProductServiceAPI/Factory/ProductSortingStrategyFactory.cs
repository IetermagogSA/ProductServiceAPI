using ProductServiceAPI.Enums;
using ProductServiceAPI.Strategy;

namespace ProductServiceAPI.Factory
{
    public class ProductSortingStrategyFactory : IProductSortingStrategyFactory
    {
        public IProductSortingStrategy GetStrategy(ProductStatusEnum productStatus)
        {
            return productStatus switch
            {
                ProductStatusEnum.Registered => new RegisteredProductSortingStrategy(),
                ProductStatusEnum.New => new UnregisteredProductSortingStrategy(),
                ProductStatusEnum.Concept => new UnregisteredProductSortingStrategy(),
                _ => throw new NotImplementedException(),
            };
        }
    }
}
