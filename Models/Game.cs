using Microsoft.EntityFrameworkCore;
using MvcGames.Models;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }

        public string? Username { get; set; }

        public Nullable<DateTime> ReviewDate { get; set; }

        public string? Review { get ; set; }

    }
}
