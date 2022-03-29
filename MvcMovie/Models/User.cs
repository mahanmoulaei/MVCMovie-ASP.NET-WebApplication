namespace MvcMovie.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public List<User>? FavoriteMovies { get; set; }
    }
}
