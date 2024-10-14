using Microsoft.Data.SqlClient;
using Supermarket_mvp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp._Repositories
{
    internal class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(ProductModel product)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Product (Product_Name, Product_Price, Product_Stock, Category_Id)
                                        VALUES (@name, @price, @stock, @categoryId)";
                command.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = product.Product_Name;
                command.Parameters.AddWithValue("@price", SqlDbType.Decimal).Value = product.Product_Price;
                command.Parameters.AddWithValue("@stock", SqlDbType.Int).Value = product.Product_Stock;
                command.Parameters.AddWithValue("@categoryId", SqlDbType.Int).Value = product.Category_Id;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Product WHERE Product_Id = @id";
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(ProductModel product)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Product
                                        SET Product_Name = @name,
                                            Product_Price = @price,
                                            Product_Stock = @stock,
                                            Category_Id = @categoryId
                                        WHERE Product_Id = @id";
                command.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = product.Product_Name;
                command.Parameters.AddWithValue("@price", SqlDbType.Decimal).Value = product.Product_Price;
                command.Parameters.AddWithValue("@stock", SqlDbType.Int).Value = product.Product_Stock;
                command.Parameters.AddWithValue("@categoryId", SqlDbType.Int).Value = product.Category_Id;
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = product.Product_Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ProductModel> GetAll()
        {
            var productList = new List<ProductModel>();

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Product ORDER BY Product_Id DESC";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var product = new ProductModel
                        {
                            Product_Id = (int)reader["Product_Id"],
                            Product_Name = reader["Product_Name"].ToString(),
                            Product_Price = (decimal)reader["Product_Price"],
                            Product_Stock = (int)reader["Product_Stock"],
                            Category_Id = (int)reader["Category_Id"]
                        };
                        productList.Add(product);
                    }
                }
            }
            return productList;
        }

        public IEnumerable<ProductModel> GetByValue(string value)
        {
            var productList = new List<ProductModel>();
            int productId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string productName = value;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Product
                                        WHERE Product_Id = @id OR Product_Name LIKE @name + '%'
                                        ORDER BY Product_Id DESC";
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = productId;
                command.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = productName;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var product = new ProductModel
                        {
                            Product_Id = (int)reader["Product_Id"],
                            Product_Name = reader["Product_Name"].ToString(),
                            Product_Price = (decimal)reader["Product_Price"],
                            Product_Stock = (int)reader["Product_Stock"],
                            Category_Id = (int)reader["Category_Id"]
                        };
                        productList.Add(product);
                    }
                }
            }

            return productList;
        }
    }
}