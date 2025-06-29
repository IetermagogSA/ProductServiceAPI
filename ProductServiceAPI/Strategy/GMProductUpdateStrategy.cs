using ProductServiceAPI.Models;

namespace ProductServiceAPI.Strategy
{
    public class GMProductUpdateStrategy : IProductUpdateStrategy
    {
        public Product UpdateProduct(Product product)
        {
            product.ModifiedBy = "SYSTEM";
            return product;
        }
    }
}
