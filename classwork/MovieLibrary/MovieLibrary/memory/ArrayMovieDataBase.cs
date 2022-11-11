// ITSE 1430
// Movie Libray

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    internal class ArrayMovieDataBase
    {
        public ArrayMovieDataBase ()
        {
            //TODO : Seed
            //Object initializer - creating and initializing new object
            // new T() {
            //   Property1 = Value1,
            //   Property2 = Value2,
            //   ...
            // }
            _items[0] = new Movie() {
                Title = "The Hateful Eight",
                Rating = "R",
                RunLength = 360,
                ReleaseYear = 2017,
                Description = "Was a banger",
                Id = 1,
            };

            _items[1] = new Movie() {
                Title = "Dune",
                Rating = "PG",
                ReleaseYear = 1982,
                RunLength = 300,
                Id = 2,
            };
            //movie = new Movie() 
            //{
            //    Title = "Jaws 2",
            //    Rating = "PG-13",
            //    ReleaseYear = 1979,
            //    RunLength = 190,
            //    Id = 3,
            //};
            _items[2] = new Movie() {
                Title = "Jaws 2",
                Rating = "PG-13",
                ReleaseYear = 1979,
                RunLength = 190,
                Id = 3,
            };
        }

        // TODO : Add
        public void Add( Movie movie )
        {

        }

        // TODO : Update
        public void Update( Movie movie )
        {

        }

        // TODO : Delete
        public void Delete( Movie movie )
        {

        }

        // TODO : Get
        public Movie Get()
        {
            return null;

        }

        // TODO : Get All
        public Movie[] GetAll()
        {
            //NEVER DO THIS - should not return a ref type directly, it can be modified
            //return _items;
            //Array.Copy() - will copy array but not ref movies

            //Need to filter out null movies
            var count = 0;
            foreach (var item in _items)
            {
                if (item != null)
                    ++count;
            };

            //Must clone both array and movies to return new copies
            //Each iteration the next element is copied to the item variable
            var items = new Movie[count];

            #region Syntax and comments

            //Don't need the for loop for enumerating arrays
            // for-statement ::= for ( Einit ; Econd ; Eupdate ) S;
            // Equivalent to
            //   Einit
            //   while (Econd) { S; Eupdate }
            //
            //for (int index = 0; index < _items.Length; ++index)
            //{ items[index] = Copy(_items[index]); };

            // Use foreach instead
            //   foreach (T variable in array) S;
            //
            // 3 limitations
            //   No index (use a simple index variable)
            //   Item is readonly
            //   Array cannot change for the life of the loop (keep a separate list)
            #endregion
            var index = 0;
            foreach (var item in _items)
            {
                if (item != null)
                    items[index++] = item.Clone();
            };

            return items;
        }
        // Arrays are always open in c#
        // Arrray size is specified at the point of creation
        private Movie[] _items = new Movie[100];
    }
}
