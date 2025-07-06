using ProductServiceAPI.Models;

namespace ProductServiceAPI.Strategy
{
    public class RegisteredProductSortingStrategy : IProductSortingStrategy
    {
        public IEnumerable<Option> SortOptions(IEnumerable<Option> options)
        {
            return options.OrderBy(o => o.Description).ToList();
        }
    }
}
