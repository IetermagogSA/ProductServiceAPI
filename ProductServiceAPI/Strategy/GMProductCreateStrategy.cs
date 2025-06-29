using ProductServiceAPI.Models;

namespace ProductServiceAPI.Strategy
{
    public class GMProductCreateStrategy : IProductCreateStrategy
    {
        public Product CreateProduct(Product product)
        {
            product.CreatedBy = "SYSTEM";
            return product;
        }
    }
}
