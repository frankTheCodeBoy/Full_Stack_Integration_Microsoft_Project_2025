using System.Text.Json;
using Microsoft.Extensions.Caching.Memory;
using Shared;

namespace MinimalAPI;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddCors(options =>
        {
            options.AddDefaultPolicy(policy =>
            {
                policy.WithOrigins("https://localhost:7033") 
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });
        });
        var app = builder.Build();
        
        app.UseCors();
        
        var memoryCache = new MemoryCache(new MemoryCacheOptions());
        var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

        Product[] products =
        [
            new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 1200.00m,
                Stock = 25,
                Category = new Category { Id = 101, Name = "Electronics" }
            },
            new Product
            {
                Id = 2,
                Name = "Headphones",
                Price = 50.00m,
                Stock = 100,
                Category = new Category { Id = 102, Name = "Accessories" }
            }
        ];
        
        app.MapGet("/api/products", () =>
        {
            //return JsonSerializer.Serialize(products, options);
            const string cacheKey = "products";
            if (!memoryCache.TryGetValue(cacheKey, out string? cachedProductsJson))
            {
                cachedProductsJson = JsonSerializer.Serialize(products, options);

                // Cache the JSON response for 5 minutes
                memoryCache.Set(cacheKey, cachedProductsJson, TimeSpan.FromMinutes(5));
            }

            return cachedProductsJson;
        });

        await app.RunAsync();
    }
}