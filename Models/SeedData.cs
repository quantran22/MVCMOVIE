using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCMovie.Data;
using System;
using System.Linq;

namespace MVCMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AplicationDBContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AplicationDBContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        MovieID = "001",
                        MovieName = "When Harry Met Sally",
                        
                    },

                    new Movie
                    {
                        MovieID = "002",
                        MovieName = "Ghostbusters ",
                    
                    },

                    new Movie
                    {
                        MovieID = "003",
                        MovieName = "Ghostbusters 2",
                        
                    },

                    new Movie
                    {
                        MovieID = "004",
                        MovieName = "Rio Bravo",
                        
                    }
                );
                context.SaveChanges();
            }
        }
    }
}