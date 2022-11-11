using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace MovieLibrary.Sql
{
    public class SqlMovieDatabase : MovieDatabase
    {
        private readonly string _connectionString;
        public SqlMovieDatabase ( string connectionString )
        {
            _connectionString = connectionString;
        }        
        protected override Movie AddCore ( Movie movie )
        {
            using(var conn = OpenConnection()) 
            {
                var cmd = new SqlCommand("AddMovie", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                /*
                 * FOR ALL THAT IS HOLY
                 * AND FOR IN THE NAME OF THE EMPOROER 
                 * DO NOT ALLOW SQL INJECTIONS
                 */

                // Add Parameters
                var parmName = new SqlParameter("@name", System.Data.SqlDbType.VarChar) {
                    Value = movie.Title,
                };

                // Approach 2
                cmd.Parameters.Add(parmName);
                var parmRating = cmd.CreateParameter();
                parmRating.ParameterName = "@rating";
                parmRating.SqlDbType = System.Data.SqlDbType.VarChar;
                parmRating.Value = movie.Rating;
                cmd.Parameters.Add(parmRating);

                // Approach 3 !!! ONLY WORKS WITH SQL   
                cmd.Parameters.AddWithValue("@description", movie.Description);
                cmd.Parameters.AddWithValue("@releaseYear", movie.ReleaseYear);
                cmd.Parameters.AddWithValue("@runLength", movie.RunLength);
                cmd.Parameters.AddWithValue("@isClassic", movie.IsClassic);

                object result = cmd.ExecuteScalar();
                movie.Id = Convert.ToInt32(result);
            };
            return movie;
        }
        protected override void DeleteCore ( int id )
        {
            using(var conn = OpenConnection())
            {
                var cmd = new SqlCommand("DeleteMovie", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);

                cmd.BeginExecuteNonQuery();
            }
        }
        protected override Movie FindById ( int id ) => GetCore(id);
        protected override Movie FindByTitle ( string title )
        {
            using (var conn = OpenConnection())
            {
                var cmd = new SqlCommand("FindByName", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@name", title);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Movie() {
                            Id = Convert.ToInt32(reader[0]),  //Ordinal and indexing
                            Title = Convert.ToString(reader["Name"]),

                            Description = reader.IsDBNull(2) ? "" : reader.GetString(2),
                            Rating = reader.GetString("Rating"),

                            ReleaseYear = reader.GetFieldValue<int>(4),
                            RunLength = reader.GetFieldValue<int>("RunLength"),

                            IsClassic = reader.GetFieldValue<bool>("IsClassic"),

                        };
                    };
                }
            };
            return null;
        }
        protected override IEnumerable<Movie> GetAllCore ()
        {
            //  Datasets are in memory representations of databases
            //  Buffered so DB isn't needed once loaded
            var ds = new DataSet();

            using (var conn = OpenConnection())
            {
                var cmd = new SqlCommand("GetMovies", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //  Load the data, connection must be open
                //     1. must create adapter and associate with command
                //     2. Must create Dataset
                //     3. Call Fill on adapter
                var adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
            };

            //  Enumerate results
            //      1. Find the table
            //      2. Enumerate the rows
            //      3. Extract the data by ordinal or name
            //      Have to use OfType<T> to convert from IEnumerable that dataset uses
            var table = ds.Tables.OfType<DataTable>().FirstOrDefault();
            if (table != null)
            {
                //  foreach (DataRow row in table.Rows)
                foreach (var row in table.Rows.OfType<DataRow>())
                {
                    //  Ordinal vs Name
                    //      Ordinal - faster but tied to order of query
                    //      Name - cleaner but slower
                    yield return new Movie() {
                        Id = Convert.ToInt32(row[0]),  //   Ordinal and indexing
                        Title = Convert.ToString(row["Name"]),  //  Name and indexing

                        Description = row.IsNull(2) ? "" : row.Field<string>(2),  //    Ordinal and generic
                        Rating = row.Field<string>("Rating"), //    Name and generic

                        ReleaseYear = row.Field<int>("ReleaseYear"),
                        RunLength = row.Field<int>("RunLength"),
                        IsClassic = row.Field<bool>("IsClassic")
                    };
                };
            };
        }
        protected override Movie GetCore ( int id )
        {
            using (var conn = OpenConnection())
            {
                var cmd = new SqlCommand("GetMovie", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Movie() {
                            Id = Convert.ToInt32(reader[0]),  //Ordinal and indexing
                            Title = Convert.ToString(reader["Name"]),

                            Description = reader.IsDBNull(2) ? "" : reader.GetString(2),
                            Rating = reader.GetString("Rating"),

                            ReleaseYear = reader.GetFieldValue<int>(4),
                            RunLength = reader.GetFieldValue<int>("RunLength"),

                            IsClassic = reader.GetFieldValue<bool>("IsClassic"),

                        };
                    };
                }
            };
            return null;
        }
        protected override void UpdateCore ( int id, Movie movie )
        {
            using (var conn = OpenConnection())
            {
                var cmd = new SqlCommand("UpdateMovie", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);

                // Add Parameters
                var parmName = new SqlParameter("@name", System.Data.SqlDbType.VarChar) {
                    Value = movie.Title,
                };

                // Approach 2
                cmd.Parameters.Add(parmName);
                var parmRating = cmd.CreateParameter();
                parmRating.ParameterName = "@rating";
                parmRating.SqlDbType = System.Data.SqlDbType.VarChar;
                parmRating.Value = movie.Rating;
                cmd.Parameters.Add(parmRating);

                // Approach 3 !!! ONLY WORKS WITH SQL   
                cmd.Parameters.AddWithValue("@description", movie.Description);
                cmd.Parameters.AddWithValue("@releaseYear", movie.ReleaseYear);
                cmd.Parameters.AddWithValue("@runLength", movie.RunLength);
                cmd.Parameters.AddWithValue("@isClassic", movie.IsClassic);

                object result = cmd.ExecuteScalar();
                movie.Id = Convert.ToInt32(result);
            };
        }
        private SqlConnection OpenConnection ()
        {            
            var conn = new SqlConnection(_connectionString);
            conn.Open();
            return conn;
        }
    }
}
