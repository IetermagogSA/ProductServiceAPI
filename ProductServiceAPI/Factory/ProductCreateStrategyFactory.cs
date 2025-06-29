using ProductServiceAPI.Enums;
using ProductServiceAPI.Strategy;

namespace ProductServiceAPI.Factory
{
    public class ProductCreateStrategyFactory : IProductCreateStrategyFactory
    {
        private readonly IServiceProvider _serviceProvider;
        public ProductCreateStrategyFactory(IServiceProvider serviceProvider)
        {

            _serviceProvider = serviceProvider;

        }
        public IProductCreateStrategy GetStrategy(ProductGroupEnum productGroup)
        {
            return productGroup switch
            {
                ProductGroupEnum.Apparel => new ApparelProductCreateStrategy(),
                ProductGroupEnum.GeneralMerchandise => new GMProductCreateStrategy(),
                _ => throw new NotImplementedException(),
            };
        }
    }
}
