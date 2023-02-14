using Microsoft.EntityFrameworkCore;

namespace Mission06_crofth.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
            //Leave blank for now
        }

        public DbSet<Movie> Movies { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId= 1,
                    Title= "WALL-E",
                    Category= "Family",
                    Year= 2008,
                    Director= "Andrew Stanton",
                    Rating= "G"
                },
                new Movie
                {
                    MovieId= 2,
                    Title= "Knives Out",
                    Category= "Drama",
                    Year= 2019,
                    Director= "Rian Johnson",
                    Rating= "PG-13"
                },
                new Movie
                {
                    MovieId= 3,
                    Title= "La La Land",
                    Category= "Drama",
                    Year= 2016,
                    Director= "Damien Chazelle",
                    Rating= "PG-13"
                }
            );
        }
    }
}
