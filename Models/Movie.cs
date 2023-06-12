using System;
using System.Collections.Generic;

namespace MoviesDBConnection;

public partial class Movie
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public DateTime? ReleaseDate { get; set; }

    public string? Genre { get; set; }

    public decimal? Rating { get; set; }
}
