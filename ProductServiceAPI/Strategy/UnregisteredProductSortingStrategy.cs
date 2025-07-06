using ProductServiceAPI.Models;

namespace ProductServiceAPI.Strategy
{
    public class UnregisteredProductSortingStrategy : IProductSortingStrategy
    {
        public IEnumerable<Option> SortOptions(IEnumerable<Option> options)
        {
            return options.OrderBy(o => o.Id).ToList();
        }
    }
}
