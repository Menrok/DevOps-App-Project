using DevOpsProject.Models;

namespace DevOpsProject.Services;

public static class ProductService
{
    public static List<Product> GetProducts()
    {
        return new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 3999.99m, InStock = true },
            new Product { Id = 2, Name = "Mouse", Price = 99.99m, InStock = true },
            new Product { Id = 3, Name = "Keyboard", Price = 199.99m, InStock = false }
        };
    }
}
