using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {

                //Look for any movies
                if (context.Movie.Any())
                {
                    return; //FB has been seeded
                }

                Movie m1 = new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1982-2-12"),
                    Genre = "Romantic Comedy"
                };

                Movie m2 = new Movie
                {
                    Title = "Ghostbusters",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy"
                };

                context.Movie.Add(m1);
                context.Movie.Add(m2);
                User u1 = new User
                {
                    Name = "Mahan",
                    FavoriteMovies = new List<Movie> { m1, m2 }
                };

                context.User.Add(u1);
                context.SaveChanges();
            }
        
        }
        
    }
}
