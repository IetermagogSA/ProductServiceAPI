using ProductServiceAPI.Models;

namespace ProductServiceAPI.Strategy
{
    public class ApparelProductUpdateStrategy : IProductUpdateStrategy
    {
        public Product UpdateProduct(Product product)
        {
            product.ModifiedBy = "APPAREL TEAM";
            return product;
        }
    }
}
