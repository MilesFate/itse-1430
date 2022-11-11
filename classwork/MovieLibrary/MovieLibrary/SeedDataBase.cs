using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    public static class SeedDataBase
    {
        public static void Seed ( this IMovieDatabase database )
        {
            var movies = new[] {
                new Movie() {
                    Title = "Jaws",
                    Rating = "PG",
                    RunLength = 210,
                    ReleaseYear = 1977,
                    Description = "Shark movie",
                },
                new Movie() {
                    Title = "Dune",
                    Rating = "PG",
                    ReleaseYear = 1982,
                    RunLength = 300
                },
                new Movie() {
                    Title = "Jaws 2",
                    Rating = "PG-13",
                    ReleaseYear = 1979,
                    RunLength = 190
                }
            };
            foreach(var movie in movies)
                database.Add(movie);
        }
    }
}
