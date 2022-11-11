/*
* Luisalberto Castaneda
* 12/07/2021
* ITSE 1430
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Nile.Stores.Sql
{
    public class SqlProductDatabase : ProductDatabase
    {

        #region SQL 
        
        private readonly string _connectionString;
        public SqlProductDatabase (string connectionString)
        {
            _connectionString = connectionString;
        }

        private SqlConnection OpenConnection ()
        {
            var conn = new SqlConnection(_connectionString);
            conn.Open();

            return conn;
        }
        #endregion

        #region Cores

        protected override Product GetCore ( int id )
        {
            using (var conn = OpenConnection())
            {
                var command = new SqlCommand("GetProduct", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Product() {
                            Id = reader.GetFieldValue<int>("Id"),
                            Name = reader.GetFieldValue<string>("Name"),
                            Price = reader.GetFieldValue<decimal>("Price"),
                            Description = reader.GetFieldValue<string>("Description"),
                            IsDiscontinued = reader.GetFieldValue<bool>("IsDiscontinued"),
                        };
                    }
                }
            }
            return null;
        }

        protected override IEnumerable<Product> GetAllCore ()
        {
            var data = new DataSet();

            using (var conn = OpenConnection())
            {
                var command = new SqlCommand("GetAllProducts", conn);
                command.CommandType = CommandType.StoredProcedure;

                var adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
            }
            var table = data.Tables.OfType<DataTable>().FirstOrDefault();

            if (table != null)
            {
                foreach (var row in table.Rows.OfType<DataRow>())
                {
                    yield return new Product() {
                        Id = row.Field<int>("Id"),
                        Name = row.Field<string>("Name"),
                        Price = row.Field<decimal>("Price"),
                        Description = row.Field<string>("Description"),
                        IsDiscontinued = row.Field<bool>("IsDiscontinued"),
                    };
                }
            }
        }

        protected override Product AddCore ( Product product )
        {
            using (var conn = OpenConnection())
            {
                var command = new SqlCommand("AddProduct", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@price", product.Price);
                command.Parameters.AddWithValue("@description", product.Description);
                command.Parameters.AddWithValue("@isDiscontinued", product.IsDiscontinued);

                object result = command.ExecuteScalar();
                product.Id = Convert.ToInt32(result);
            }
            return product;
        }

        protected override Product UpdateCore ( Product existing, Product product )
        {
            using (var conn = OpenConnection())
            {
                var command = new SqlCommand("UpdateProduct", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", existing.Id);
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@price", product.Price);
                command.Parameters.AddWithValue("@description", product.Description);
                command.Parameters.AddWithValue("@isDiscontinued", product.IsDiscontinued);

                command.ExecuteNonQuery();
            }
            return product;
        }
      
        protected override void RemoveCore ( int id )
        {
            using (var conn = OpenConnection())
            {
                var cmd = new SqlCommand("RemoveProduct", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Find By
        protected override Product FindByName ( string name )
        {
            var products = GetAll();

            foreach (Product product in products)
            {
                if (product.Name.Equals(name))
                {
                    return new Product {
                        Id = product.Id,
                        Name = product.Name,
                        Price = product.Price,
                        IsDiscontinued = product.IsDiscontinued,
                    };
                }
            }
            return null;
        }
        #endregion
    }
}
