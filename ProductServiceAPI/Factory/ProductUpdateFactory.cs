using ProductServiceAPI.Enums;
using ProductServiceAPI.Models;
using ProductServiceAPI.Strategy;

namespace ProductServiceAPI.Factory
{
    public class ProductUpdateStrategyFactory : IProductUpdateStrategyFactory
    {
        public IProductUpdateStrategy GetUpdateStrategy(ProductGroupEnum productGroup)
        {
            return productGroup switch
            {
                ProductGroupEnum.GeneralMerchandise => new GMProductUpdateStrategy(),
                ProductGroupEnum.Apparel => new ApparelProductUpdateStrategy(),
                _ => throw new NotImplementedException()
            };
        }
    }
}
