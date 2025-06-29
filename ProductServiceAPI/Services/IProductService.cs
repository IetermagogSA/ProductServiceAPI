using ProductServiceAPI.Models;

namespace ProductServiceAPI.Services
{
    public interface IProductService
    {
        public Product Create(Product product);
        public Product Update(Product product);

    }
}
