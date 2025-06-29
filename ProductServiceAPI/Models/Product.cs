using ProductServiceAPI.Enums;
using System.Text.Json.Serialization;

namespace ProductServiceAPI.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ProductStatusEnum Status { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ProductGroupEnum Group { get; set; }
        public IEnumerable<Option> Options { get; set; }
        public string? CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
