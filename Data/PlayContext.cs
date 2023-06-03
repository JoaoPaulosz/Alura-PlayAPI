using Alura_Play.Models;
using Microsoft.EntityFrameworkCore;

namespace Alura_Play.Data
{
    public class PlayContext : DbContext
    {
        public PlayContext(DbContextOptions<PlayContext> options) 
            : base(options) 
        {

        }

        public DbSet<Play> Plays { get; set; }
    }
}
