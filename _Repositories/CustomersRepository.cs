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
    internal class CustomersRepository : BaseRepository, ICustomerRepository
    {
        public CustomersRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(CustomersModel customer)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Customer 
                                        (Document_Number, First_Name, Last_Name, Address, Phone_Number, Birthday,  Email)
                                        VALUES (@documentNumber, @firstName, @lastName, @address, @phoneNumber, @birthDay, @email)";
                command.Parameters.AddWithValue("@documentNumber", SqlDbType.NVarChar).Value = customer.Document_Number;
                command.Parameters.AddWithValue("@firstName", SqlDbType.NVarChar).Value = customer.First_Name;
                command.Parameters.AddWithValue("@lastName", SqlDbType.NVarChar).Value = customer.Last_Name;
                command.Parameters.AddWithValue("@address", SqlDbType.NVarChar).Value = customer.Address;
                command.Parameters.AddWithValue("@birthDay", SqlDbType.NVarChar).Value = customer.Birthday;
                command.Parameters.AddWithValue("@phoneNumber", SqlDbType.NVarChar).Value = customer.Phone_Number;
                command.Parameters.AddWithValue("@email", SqlDbType.NVarChar).Value = customer.Email;
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
                command.CommandText = "DELETE FROM Customer WHERE Customer_Id = @id";
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(CustomersModel customer)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Customer
                                        SET Document_Number = @documentNumber,
                                            First_Name = @firstName,
                                            Last_Name = @lastName,
                                            Address = @address,
                                            Birthday = @birthDay, 
                                            Phone_Number = @phoneNumber,                                      
                                            Email = @email
                                        WHERE Customer_Id = @id";
                command.Parameters.AddWithValue("@documentNumber", SqlDbType.NVarChar).Value = customer.Document_Number;
                command.Parameters.AddWithValue("@firstName", SqlDbType.NVarChar).Value = customer.First_Name;
                command.Parameters.AddWithValue("@lastName", SqlDbType.NVarChar).Value = customer.Last_Name;
                command.Parameters.AddWithValue("@address", SqlDbType.NVarChar).Value = customer.Address;
                command.Parameters.AddWithValue("@birthDay", SqlDbType.NVarChar).Value = customer.Birthday;
                command.Parameters.AddWithValue("@phoneNumber", SqlDbType.NVarChar).Value = customer.Phone_Number;
                command.Parameters.AddWithValue("@email", SqlDbType.NVarChar).Value = customer.Email;
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = customer.Customer_Id;
                command.ExecuteNonQuery();
            }
        }
        public IEnumerable<CustomersModel> GetAll()
        {
            var customersList = new List<CustomersModel>();

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Customer ORDER BY Customer_Id DESC";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customer = new CustomersModel
                        {
                            Customer_Id = (int)reader["Customer_Id"],
                            Document_Number = reader["Document_Number"].ToString(),
                            First_Name = reader["First_Name"].ToString(),
                            Last_Name = reader["Last_Name"].ToString(),
                            Address = reader["Address"].ToString(),
                            Birthday = (DateTime)reader["Birthday"],
                            Phone_Number = reader["Phone_Number"].ToString(),
                            Email = reader["Email"].ToString()
                        };
                        customersList.Add(customer);
                    }
                }
            }

            return customersList;
        }

        public IEnumerable<CustomersModel> GetByValue(string value)
        {
            var customersList = new List<CustomersModel>();

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                command.CommandText = @"
            SELECT * FROM Customer
            WHERE Customer_Id = @id 
            OR Document_Number LIKE @searchValue + '%'
            OR First_Name LIKE @searchValue + '%'
            OR Last_Name LIKE @searchValue + '%'
            ORDER BY Customer_Id DESC";

                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = int.TryParse(value, out int id) ? id : 0;
                command.Parameters.AddWithValue("@searchValue", SqlDbType.NVarChar).Value = value;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customer = new CustomersModel
                        {
                            Customer_Id = (int)reader["Customer_Id"],
                            Document_Number = reader["Document_Number"].ToString(),
                            First_Name = reader["First_Name"].ToString(),
                            Last_Name = reader["Last_Name"].ToString(),
                            Address = reader["Address"].ToString(),
                            Birthday = (DateTime)reader["Birthday"],
                            Phone_Number = reader["Phone_Number"].ToString(),
                            Email = reader["Email"].ToString()
                        };
                        customersList.Add(customer);
                    }
                }
            }

            return customersList;
        }
    }
}
