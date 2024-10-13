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
    internal class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public void Add(CategoryModel category)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO PayMode VALUES (@name, @description)";
                command.Parameters.AddWithValue("@name",
                 SqlDbType.NVarChar).Value = category.Category_Name;
                command.Parameters.AddWithValue("@observation", SqlDbType.NVarChar).Value = category.Description;
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
                command.CommandText = "DELETE FROM Category WHERE Category_Id = @id";
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(CategoryModel category)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Category
                              SET Category_Name = @name,
                                  Category_Description = @description
                              WHERE Category_Id = @id";
                command.Parameters.AddWithValue("@name",
                SqlDbType.NVarChar).Value = category.Category_Name;
                command.Parameters.AddWithValue("@description", SqlDbType.NVarChar).Value = category.Description;
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = category.Category_Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<CategoryModel> GetAll()
        {
            var categoryList = new List<CategoryModel>();

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Category ORDER BY Category_Id DESC";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoryModel = new CategoryModel();
                        categoryModel.Category_Id = (int)reader["Category_Id"];
                        categoryModel.Category_Name = reader["Category_Name"].ToString();
                        categoryModel.Description = reader["Description"].ToString();
                        categoryList.Add(categoryModel);
                    }
                }
            }

            return categoryList;
        }

        public IEnumerable<CategoryModel> GetByValue(string searchValue)
        {
            var categoryList = new List<CategoryModel>();
            int categoryId = int.TryParse(searchValue, out _) ? Convert.ToInt32(searchValue) : 0;
            string categoryName = searchValue;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Category
                                        WHERE Category_Id=@id or Category_Name LIKE @name+ '%'
                                        ORDER By Category_Id Desc";
                command.Parameters.Add("@id", SqlDbType.Int).Value = categoryId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoryName;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoryModel = new CategoryModel();
                        categoryModel.Category_Id = (int)reader["Category_Id"];
                        categoryModel.Category_Name = reader["Category_Name"].ToString();
                        categoryModel.Description = reader["Category_Description"].ToString();
                        categoryList.Add(categoryModel);
                    }
                }
            }

            return categoryList;
        }
    }
}
