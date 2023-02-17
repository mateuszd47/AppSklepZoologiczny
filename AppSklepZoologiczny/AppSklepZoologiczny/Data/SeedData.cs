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
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Aquael Ultramax 2000",
                        Description = "Filtr kubełkowy",
                        CategoryId = 2,
                        Price = Decimal.Parse("700"),
                        Availability = true
                    },
                    new Product
                    {
                        Name = "Aquael Platinum 200w",
                        Description = "Grzałka",
                        CategoryId = 6,
                        Price = Decimal.Parse("150"),
                        Availability = true
                    },
                    new Product
                    {
                        Name = "Owczarek Niemiecki",
                        Description = "Pies duży",
                        CategoryId = 8,
                        Price = Decimal.Parse("2000"),
                        Availability = true
                    },
                    new Product
                    {
                        Name = "Akwarium 300L",
                        Description = "Rozmiar 120x50x50(cm)",
                        CategoryId = 4,
                        Price = Decimal.Parse("600"),
                        Availability = true
                    },
                    new Product
                    {
                        Name = "Aquael Kostka 27L",
                        Description = "Rozmiar 30x30x30(cm)",
                        CategoryId = 4,
                        Price = Decimal.Parse("200"),
                        Availability = true
                    }
                );
                context.SaveChanges();
                context.Customers.AddRange(
                    new Customer
                    {
                        Username= "mateuszd67",
                        Firstname = "Mateusz",
                        Lastname = "Dynur",
                        PhoneNumber = 932233444,
                        Email = "mati@wp.pl",
                        Address = "Bochnia Ul.Kwiatowa 17"
                    },
                    new Customer
                    {
                        Username= "JJKubi33",
                        Firstname = "Jakub",
                        Lastname = "Kołodziej",
                        PhoneNumber = 666666666,
                        Email = "kuba@gamil.com",
                        Address = "Kraków Ul.Szewska 12"
                    }
                );
                context.SaveChanges();
                context.Orders.AddRange(
                    new Order
                    {
                        CustomerId = 2,
                        DateTimeOrder = DateTime.Parse("2023-02-18 07:35:00"),
                        ProductId = 3,
                        Quantity= 1,
                        UnitPrice = Decimal.Parse("2000")
                    },
                     new Order
                     {
                         CustomerId = 1,
                         DateTimeOrder = DateTime.Parse("2023-02-18 08:36:00"),
                         ProductId = 1,
                         Quantity = 1,
                         UnitPrice = Decimal.Parse("700")
                     },
                     new Order
                     {
                          CustomerId = 1,
                          DateTimeOrder = DateTime.Parse("2023-02-18 08:36:00"),
                          ProductId = 4,
                          Quantity = 1,
                          UnitPrice = Decimal.Parse("600")
                     }
                );
                context.SaveChanges();
                context.Deliveriess.AddRange(
                   new Deliveries
                   {
                       OrderId = 1,
                       DateTimeDeliveries = DateTime.Parse("2023-02-20 12:00:00"),
                       IsDelivery = false
                   },
                   new Deliveries
                   {
                       OrderId = 2,
                       DateTimeDeliveries = DateTime.Parse("2023-02-21 12:00:00"),
                       IsDelivery = false
                   },
                   new Deliveries
                   {
                       OrderId = 3,
                       DateTimeDeliveries = DateTime.Parse("2023-02-21 12:00:00"),
                       IsDelivery = false
                   }

               );
                context.SaveChanges();
            }
        }
    }
}
