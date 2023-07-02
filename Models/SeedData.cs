using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcGames.Data;
using MvcMovie.Models;
using System;
using System.Linq;

namespace MvcGames.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider) 
        {
            using (var context = new MvcGamesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcGamesContext>>()))
            {
                if (context.Game.Any())
                {
                    return;
                }

                context.Game.AddRange(
                    new Game
                    {
                        Title = "The Crew",
                        ReleaseDate = DateTime.Parse("2023-9-14"),
                        Genre = "Racing",
                        Price = 100.00M,
                    },

                    new Game
                    {
                        Title = "Globs & Ghosts",
                        ReleaseDate = DateTime.Parse("2023-6-30"),
                        Genre = "Arcade",
                        Price = 4.99M
                    },

                    new Game
                    {
                        Title = "Martian Panic",
                        ReleaseDate = DateTime.Parse("2023-6-30"),
                        Genre = "Shooter",
                        Price = 21.99M
                    },
                    new Game
                    {
                        Title = "asd",
                        ReleaseDate = DateTime.Parse("2023-6-30"),
                        Genre = "Shooter",
                        Price = 21.99M
                    },
                    new Game
                    {
                        Title = "asd",
                        ReleaseDate = DateTime.Parse("2023-6-30"),
                        Genre = "Shooter",
                        Price = 21.99M
                    },
                    new Game
                    {
                        Title = "asd",
                        ReleaseDate = DateTime.Parse("2023-6-30"),
                        Genre = "Shooter",
                        Price = 21.99M
                    },
                    new Game
                    {
                        Title = "asd",
                        ReleaseDate = DateTime.Parse("2023-6-30"),
                        Genre = "Shooter",
                        Price = 21.99M
                    },
                    new Game
                    {
                        Title = "asd",
                        ReleaseDate = DateTime.Parse("2023-6-30"),
                        Genre = "Shooter",
                        Price = 21.99M
                    },
                    new Game
                    {
                        Title = "asd",
                        ReleaseDate = DateTime.Parse("2023-6-30"),
                        Genre = "Shooter",
                        Price = 21.99M
                    },
                    new Game
                    {
                        Title = "asd",
                        ReleaseDate = DateTime.Parse("2023-6-30"),
                        Genre = "Shooter",
                        Price = 21.99M
                    },
                    new Game
                    {
                        Title = "asd",
                        ReleaseDate = DateTime.Parse("2023-6-30"),
                        Genre = "Shooter",
                        Price = 21.99M
                    },
                    new Game
                    {
                        Title = "asd",
                        ReleaseDate = DateTime.Parse("2023-6-30"),
                        Genre = "Shooter",
                        Price = 21.99M
                    },
                    new Game
                    {
                        Title = "asd",
                        ReleaseDate = DateTime.Parse("2023-6-30"),
                        Genre = "Shooter",
                        Price = 21.99M
                    },
                    new Game
                    {
                        Title = "asd",
                        ReleaseDate = DateTime.Parse("2023-6-30"),
                        Genre = "Shooter",
                        Price = 21.99M
                    },
                    new Game
                    {
                        Title = "asd",
                        ReleaseDate = DateTime.Parse("2023-6-30"),
                        Genre = "Shooter",
                        Price = 21.99M
                    },
                    new Game
                    {
                        Title = "asd",
                        ReleaseDate = DateTime.Parse("2023-6-30"),
                        Genre = "Shooter",
                        Price = 21.99M
                    },
                    new Game
                    {
                        Title = "asd",
                        ReleaseDate = DateTime.Parse("2023-6-30"),
                        Genre = "Shooter",
                        Price = 21.99M
                    },
                    new Game
                    {
                        Title = "asd",
                        ReleaseDate = DateTime.Parse("2023-6-30"),
                        Genre = "Shooter",
                        Price = 21.99M
                    },
                    new Game
                    {
                        Title = "asd",
                        ReleaseDate = DateTime.Parse("2023-6-30"),
                        Genre = "Shooter",
                        Price = 21.99M
                    },
                    new Game
                    {
                        Title = "asd",
                        ReleaseDate = DateTime.Parse("2023-6-30"),
                        Genre = "Shooter",
                        Price = 21.99M
                    },
                    new Game
                    {
                        Title = "asd",
                        ReleaseDate = DateTime.Parse("2023-6-30"),
                        Genre = "Shooter",
                        Price = 21.99M
                    },
                    new Game
                    {
                        Title = "asd",
                        ReleaseDate = DateTime.Parse("2023-6-30"),
                        Genre = "Shooter",
                        Price = 21.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
