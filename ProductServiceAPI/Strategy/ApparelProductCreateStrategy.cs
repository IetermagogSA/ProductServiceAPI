using ProductServiceAPI.Models;

namespace ProductServiceAPI.Strategy
{
    public class ApparelProductCreateStrategy : IProductCreateStrategy
    {
        public Product CreateProduct(Product product)
        {
            product.CreatedBy = "APPAREL TEAM";
            return product;
        }
    }
}
