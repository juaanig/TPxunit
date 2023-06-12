using MoviesDBConnection;

namespace TestingTP
{
    public class MovieTests
    {
        [Fact]
        public void Movie_Initialization_SetsPropertiesCorrectly()
        {
            var movie = new Movie
            {
                Id = 1,
                Title = "Example Movie",
                ReleaseDate = new DateTime(2020, 1, 1),
                Genre = "Drama",
                Rating = 4
            };

            Assert.Equal(1, movie.Id);
            Assert.Equal("Example Movie", movie.Title);
            Assert.Equal(new DateTime(2020, 1, 1), movie.ReleaseDate);
            Assert.Equal("Drama", movie.Genre);
            Assert.Equal(4, movie.Rating);
        }
    }
}
