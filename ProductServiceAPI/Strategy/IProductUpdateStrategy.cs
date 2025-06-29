using ProductServiceAPI.Models;

namespace ProductServiceAPI.Strategy
{
    public interface IProductUpdateStrategy
    {
        public Product UpdateProduct(Product product);
    }
}
