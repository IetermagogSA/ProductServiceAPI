using ProductServiceAPI.Models;

namespace ProductServiceAPI.Strategy
{
    public interface IProductCreateStrategy
    {
        public Product CreateProduct(Product product);
    }
}
