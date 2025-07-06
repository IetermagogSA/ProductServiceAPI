using ProductServiceAPI.Enums;
using ProductServiceAPI.Models;

namespace ProductServiceAPI.Data
{
    public static class ProductData
    {
        public static List<Product> GetSampleProducts() => new()
    {
        new Product
        {
            Id = Guid.NewGuid(),
            Description = "Men's T-Shirt",
            Status = ProductStatusEnum.New,
            Group = ProductGroupEnum.Apparel,
            Options = new[]
            {
                new Option { Id = Guid.NewGuid(), Description = "Size M - Blue", QualityGroup = "Standard" },
                new Option { Id = Guid.NewGuid(), Description = "Size A - Blue", QualityGroup = "Standard" },
                new Option { Id = Guid.NewGuid(), Description = "Size L - Blue", QualityGroup = "Standard" }
            }
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Description = "Blender",
            Status = ProductStatusEnum.Registered,
            Group = ProductGroupEnum.GeneralMerchandise,
            Options = new[]
            {
                new Option { Id = Guid.NewGuid(), Description = "600W Power", QualityGroup = "High" },
                new Option { Id = Guid.NewGuid(), Description = "700W Power", QualityGroup = "High" },
                new Option { Id = Guid.NewGuid(), Description = "300W Power", QualityGroup = "High" }
            }
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Description = "Women's Jacket",
            Status = ProductStatusEnum.Concept,
            Group = ProductGroupEnum.Apparel,
            Options = new[]
            {
                new Option { Id = Guid.NewGuid(), Description = "Size L - Red", QualityGroup = "Premium" }
            }
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Description = "Electric Kettle",
            Status = ProductStatusEnum.New,
            Group = ProductGroupEnum.GeneralMerchandise,
            Options = new[]
            {
                new Option { Id = Guid.NewGuid(), Description = "1.5L Capacity", QualityGroup = "Standard" }
            }
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Description = "Running Shoes",
            Status = ProductStatusEnum.Registered,
            Group = ProductGroupEnum.Apparel,
            Options = new[]
            {
                new Option { Id = Guid.NewGuid(), Description = "Size 10 - Black", QualityGroup = "Premium" }
            }
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Description = "Microwave Oven",
            Status = ProductStatusEnum.Concept,
            Group = ProductGroupEnum.GeneralMerchandise,
            Options = new[]
            {
                new Option { Id = Guid.NewGuid(), Description = "800W Power", QualityGroup = "High" }
            }
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Description = "Baseball Cap",
            Status = ProductStatusEnum.New,
            Group = ProductGroupEnum.Apparel,
            Options = new[]
            {
                new Option { Id = Guid.NewGuid(), Description = "White Color", QualityGroup = "Basic" }
            }
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Description = "Desk Lamp",
            Status = ProductStatusEnum.Registered,
            Group = ProductGroupEnum.GeneralMerchandise,
            Options = new[]
            {
                new Option { Id = Guid.NewGuid(), Description = "LED Light", QualityGroup = "Standard" }
            }
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Description = "Hoodie",
            Status = ProductStatusEnum.Concept,
            Group = ProductGroupEnum.Apparel,
            Options = new[]
            {
                new Option { Id = Guid.NewGuid(), Description = "Size S - Gray", QualityGroup = "Premium" }
            }
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Description = "Toaster",
            Status = ProductStatusEnum.New,
            Group = ProductGroupEnum.GeneralMerchandise,
            Options = new[]
            {
                new Option { Id = Guid.NewGuid(), Description = "2-Slot", QualityGroup = "Basic" }
            }
        }
    };
    }
}

