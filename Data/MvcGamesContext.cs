using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcGames.Data
{
    public class MvcGamesContext : DbContext
    {

        public DbSet<MvcMovie.Models.Game> Game { get; set; } = default!;

        public MvcGamesContext(DbContextOptions<MvcGamesContext> options)
            : base(options)
        {
        }
    }
}
