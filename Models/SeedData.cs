using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MopMarvels.Data;
using System;
using System.Linq;
using System.Net.Sockets;

namespace MopMarvels.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MopMarvelsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MopMarvelsContext>>()))
            {
                // Look for any movies.
                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }
                context.Product.AddRange(
                    new Product
                    {
                        Name = "EasyWring RinseClean Spin Mop & Bucket System",
                        MFGDate = DateTime.Parse("2020-12-25"),
                        SerialNumber = "BHdgwi123",
                        Price = 125,
                        Rating = 4,
                        Category = "Bucket"
                    },
                    new Product
                    {
                        Name = "Premium Spray Mop for Hardwood Floors",
                        MFGDate = DateTime.Parse("2023-10-08"),
                        SerialNumber = "spray123456",
                        Price = 50,
                        Rating = 5,
                        Category = "Spray Mop"
                    },
                    new Product
                    {
                        Name = "Flat Mop Cleaning System",
                        MFGDate = DateTime.Parse("2022-06-30"),
                        SerialNumber = "mjdwbuw9857",
                        Price = 96,
                        Rating = 5,
                        Category = "Flat Mop"
                    },
                    new Product
                    {
                        Name = "ProMist Max Microfibre Spray Mop",
                        MFGDate = DateTime.Parse("2024-02-25"),
                        SerialNumber = "qwerty123098",
                        Price = 20,
                        Rating = 3,
                        Category = "Spray Mop"
                    },
                     new Product
                     {
                         Name = "22-inch Giant Microfiber Flip Mop",
                         MFGDate = DateTime.Parse("2021-11-08"),
                         SerialNumber = "mcbdvy",
                         Price = 65,
                         Rating = 4,
                         Category = "Flip Mop"
                     },
                      new Product
                      {
                          Name = "Bee Mop Classic",
                          MFGDate = DateTime.Parse("2023-04-25"),
                          SerialNumber = "fhuegwu9",
                          Price = 96,
                          Rating = 5,
                          Category = "Classic"
                      },
                       new Product
                       {
                           Name = "EasyWring RinseClean Spin Mop & Bucket System",
                           MFGDate = DateTime.Parse("2020-12-25"),
                           SerialNumber = "BHdgwi123",
                           Price = 125,
                           Rating = 4,
                           Category = "Bucket"
                       },
                        new Product
                        {
                            Name = "Tornado Spin Mop",
                            MFGDate = DateTime.Parse("2022-08-25"),
                            SerialNumber = "grher8",
                            Price = 87,
                            Rating = 4,
                            Category = "Spin Mop"
                        },
                         new Product
                         {
                             Name = "Spray Mop with Reusable Microfiber Pad",
                             MFGDate = DateTime.Parse("2021-01-07"),
                             SerialNumber = "ijfiewhf7",
                             Price = 45,
                             Rating = 5,
                             Category = "Spray Mop"
                         },
                          new Product
                          {
                              Name = "Super Twist 3Action XL Mop",
                              MFGDate = DateTime.Parse("2024-02-14"),
                              SerialNumber = "fhiehf78",
                              Price = 43,
                              Rating = 5,
                              Category = "XL Mop"
                          }
                );
                context.SaveChanges();
            }
        }
    }
}
