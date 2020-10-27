using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VisualMarket.Models;

namespace VisualMarket.VisualMarket.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            VisualMarketDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<VisualMarketDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any()) 
            {
                context.Products.AddRange(

                    new Product 
                    {
                        Name = "Mona Lisa",  Description = "A beautifull art painting", Category = "Painting", Price = 8586000M
                    },

                    new Product
                    {
                        Name = "Bird",  Description = "A beautifull coal/pencil drawing", Category = "Drawing", Price = 149.50M
                    },

                    new Product
                    {
                        Name = "River Mountain",  Description = "River Mountain landscape art", Category = "Landscape", Price = 368.30M
                    },

                    new Product
                    {
                        Name = "Children Playing",  Description = "A 3D art of children paling on the street", Category = "3D", Price = 58.95M
                    },

                    new Product
                    {
                        Name = "Woman Face",  Description = "A beautifull coal/pencil drawing", Category = "Drawing", Price = 48.59M
                    },

                    new Product
                    {
                        Name = "War General",  Description = "A painting of a war general", Category = "Painting", Price = 86.89M
                    },

                    new Product
                    {
                        Name = "Burning Buiding",  Description = "A painting of a burning building", Category = "Painting", Price = 46.9M
                    },

                    new Product
                    {
                        Name = "Dog",  Description = "a 3D painting of a dog", Category = "3D", Price = 179.95M
                    },

                    new Product
                    {
                        Name = "Mountain",  Description = "A beautifull coal/pencil drawing", Category = "Landscape", Price = 248.99M
                    }

                );

                context.SaveChanges();
            }
        }
    }
}