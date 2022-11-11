// ITSE 1430
// Movie Library

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;

namespace MovieLibrary.Memory
{
    public class MemoryMovieDatabase : IMovieDatabase
    {

        public void IsOnlyHere ()
        { }

        //TODO: Error handling
        public Movie Add ( Movie movie )
        {
            //Movie must be valid

            // Validation
            //  Movie is not null
            //  Movie is Valid
            //  Movie cannot already exist

            // Think of Porth thing "You cant do that, it's illegal" => assert isinstance(op.operand, OpAddr), "This could be a bug in the parsing step"
            //if (movie == null)
            //    throw new ArgumentNullException(nameof(movie));
            var item = movie ?? throw new ArgumentNullException(nameof(movie));


            ObjectValidator.Validate(movie);

            //Movie title must be unique
            var existing = FindByTitle(movie.Title);
            if (existing != null)
                throw new InvalidOperationException("Movie must be unique");

            //Clone
            var newMovie = movie.Clone();

            //Set unique ID
            newMovie.Id = _nextId++;

            _items.Add(newMovie);

            movie.Id = newMovie.Id;
            return movie;
        }
        
        //[Conditional("DEBUG")]
        //private void dump ()
        //{

        //}

        [Obsolete("Use GetCore instead")]
        private Movie FindByTitle ( string title )
        {
            return _items.FirstOrDefault(movie => String.Compare(title, movie.Title, true) == 0);
            //foreach (var movie in _items)
            //    if (String.Compare(title, movie.Title, true) == 0)
            //        return movie;

            //return null;
        }

        private Movie FindById ( int id )
        {
            // Where (Func<Movie, bool>) -> IEnumerable<T>
            //return _items.FirstOrDefault(x => x.Id == id);
            return (from movie in _items 
                    where movie.Id == id
                    select movie).FirstOrDefault();
            //foreach (var movie in _items)
            //    if (movie.Id == id)
            //        return movie;

            //return null;
        }

        //TODO: Update
        public void Update ( int id, Movie movie )
        {
            // Validation
            //    Id must be > 0
            //    Movie is not null
            //    Movie is valid
            //    Movie does not already exist            
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than 0.");
            if (movie == null)
                throw new ArgumentNullException(nameof(movie));

            //Movie must be valid
            ObjectValidator.Validate(movie);

            //Movie must exist
            var existing = FindById(id);
            if (existing == null)
                throw new Exception("Movie not found");

            //Movie title must be unique
            var dup = FindByTitle(movie.Title);
            if (dup != null && dup.Id != id)
                throw new InvalidOperationException("Movie must be unique");

            Copy(existing, movie);
        }

        private void Copy ( Movie target, Movie source )
        {
            target.Title = source.Title;
            target.Description = source.Description;
            target.Rating = source.Rating;
            target.RunLength = source.RunLength;
            target.ReleaseYear = source.ReleaseYear;
            target.IsClassic = source.IsClassic;
        }

        //Delete
        public void Delete ( int id )
        {            
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than 0.");

            var movie = FindById(id);
            if (movie != null)
                _items.Remove(movie);
        }

        //TODO: Get
        public Movie Get ( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than 0.");

            var movie = FindById(id);

            return movie?.Clone();
        }

        private class IdAndTitle
        {
            public int Id { get; set; }
            public string Title { get; set; }
        }
        //private IEnumerable<IdAndTitle> MySelect ( IEnumerable<Movie> items, Func<Movie>, IdAndTitle> converter)
        //{

        //}
        private IdAndTitle Convert (Movie movie )
        {
            return new IdAndTitle() {
                Id = movie.Id,
                Title = movie.Title
            };
        }

        //private Movie Clone (Movie movie )
        //{
        //    return movie.Clone();
        //}

        //TODO: Get All
        public IEnumerable<Movie> GetAll ()
        {
            //NEVER DO THIS - should not return a ref type directly, it can be modified
            //return _items;
            // Use Iterator Syntax
            //int counter = 0;
            IEnumerable<Movie> items = _items;
            // Select transforms S to T
            //IEnumerable<IdAndTitle> titles =  _items.Select(Convert);
            //return _items.Select(x => x.Clone());
            return from x in _items
                   select x.Clone();
            //foreach (var item in _items)
            //{
            //    //++counter;
            //    yield return item.Clone();
            //};

            //Must clone both array and movies to return new copies
            //Each iteration the next element is copied to the item variable            
            //var items = new Movie[_items.Count];

            //var index = 0;
            //foreach (var item in _items)
            //    items[index++] = item.Clone();

            //return items;
        }

        //Dynamically resizing array
        private List<Movie> _items = new List<Movie>();
        private int _nextId = 1;
    }
}
