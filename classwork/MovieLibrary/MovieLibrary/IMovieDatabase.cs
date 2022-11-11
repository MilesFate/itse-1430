// ITSE 1430
// Movie Library

using System.Collections.Generic;

namespace MovieLibrary
{
    // All members are always public, cannot specify access
    // Only type members that are not implementation details are allowed
    //   Methods, properties, events
    // The implementation is not provided

    /// <summary>Represents a movie database.</summary>
    public interface IMovieDatabase
    {
        /// <summary>Adds a movie to the database.</summary>
        /// <param name="movie">The movie to add.</param>
        /// <param name="error">The error that occurred.</param>
        /// <returns>The added movie.</returns>
        /// <remarks>
        /// Movie must be not null and valid.
        /// Movie title must be unique.
        /// </remarks>
        Movie Add ( Movie movie );

        /// <summary>Deletes a movie.</summary>
        /// <param name="id">The ID of the movie.</param>
        /// <remarks>
        /// Id must be greater than zero.
        /// </remarks>
        void Delete ( int id );

        /// <summary>Gets a movie, if any.</summary>
        /// <param name="id">The ID of the movie.</param>
        /// <remarks>
        /// Id must be greater than zero.
        /// </remarks>
        Movie Get ( int id );

        /// <summary>Gets all movies.</summary>                
        IEnumerable<Movie> GetAll ();

        /// <summary>Updates a movie in the database.</summary>
        /// <param name="id">The ID of the movie to update.</param>
        /// <param name="movie">The updated movie.</param>
        /// <param name="error">The error that occurred.</param>
        /// <remarks>        
        /// Movie must be not null and valid.
        /// Movie title must be unique.
        /// Movie must already exist.
        /// Id must be greater than zero.
        /// </remarks>
        void Update ( int id, Movie movie );
    }
}