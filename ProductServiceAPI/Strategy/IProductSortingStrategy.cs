using ProductServiceAPI.Models;

namespace ProductServiceAPI.Strategy
{
    public interface IProductSortingStrategy
    {
        public IEnumerable<Option> SortOptions(IEnumerable<Option> options);
    }
}
