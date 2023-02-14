using Microsoft.EntityFrameworkCore;

namespace Mission06_crofth.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
            //Leave blank for now
        }

        public DbSet<Movie> movies { get; set;}
    }
}
