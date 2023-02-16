using AppSklepZoologiczny.Models;
using Microsoft.EntityFrameworkCore;

namespace AppSklepZoologiczny.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                context.Database.EnsureCreated();

                if (context.Categories.Any())
                {
                    return; // dane już zostały dodane do bazy danych
                }
                context.Categories.AddRange(
                    new Category
                    {
                        Name = "Ryby"
                    },
                    new Category
                    {
                        Name = "Filtry"
                    },
                    new Category
                    {
                        Name = "Akcessoria"
                    },
                    new Category
                    {
                        Name = "Akwaria"
                    },
                    new Category
                    {
                        Name = "Lekarstwa"
                    },
                    new Category
                    {
                        Name = "Grzałki"
                    },
                    new Category
                    {
                        Name = "Rośliny"
                    },
                    new Category
                    {
                        Name = "Psy"
                    },
                    new Category
                    {
                        Name = "Koty"
                    },
                    new Category
                    {
                        Name = "Chomiki"
                    },
                    new Category
                    {
                        Name = "Świnki Morskie"
                    },
                    new Category
                    {
                        Name = "Króliki"
                    },
                    new Category
                    {
                        Name = "Pokarmy"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
