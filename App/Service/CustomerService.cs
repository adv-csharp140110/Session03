using App.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Service
{
    public class CustomerService
    {
        string connString = "Server=.; Database=ADVCS_140110; Trusted_Connection=true";
        //CRUD

        public void Create(Customer model) {
            // validate model
            // validate business

            /**
             *  1. new SQLConnection
             *  2. new SQLCommand 
             *  3. SQLCommand. Text -> insert, update,...
             *  4. SQLCommand.connection
             *  5. SQLConnection.open
             *  6. SQLCommand.execute
             *  7. SQLConnection.close
             */
            //var connString = "SErver=IP;Database=DB; User Id=USER; Password=PASSWORD";
            //var connString = "SErver=IP;Database=DB; Trusted_Connection=true";
            //https://www.connectionstrings.com/
            
            //ADO.net 

            var conn = new SqlConnection(connString);
            var command = new SqlCommand();
            /*
            //String intepolation
            //command.CommandText = $@"INSERT INTO [dbo].[Customer]
            //       ([FirstName]
            //       ,[LastName]
            //       ,[NationalCode]
            //       ,[Email]
            //       ,[DOB]
            //       ,[IsActive]
            //       ,[Address])
            // VALUES
            //       ('{model.FirstName}'
            //       ,'{model.LastName}'
            //       ,'{model.NationalCode}'
            //       ,'{model.Email}'
            //       ,{model.DOB}
            //       ,{model.IsActive}
            //       ,'{model.Address}')";
            /* SQL INJECTION 
             * FirstName: ali
             * FirstName: ali'); delete customer;
             * 
             */


            command.CommandText = @"INSERT INTO [dbo].[Customer]
                   ([FirstName]
                   ,[LastName]
                   ,[NationalCode]
                   ,[Email]
                   ,[DOB]
                   ,[IsActive]
                   ,[Address])
             VALUES
                   (@FirstName
                   ,@LastName
                   ,@NationalCode
                   ,@Email
                   ,@DOB
                   ,@IsActive
                   ,@Address)";

            command.Parameters.AddWithValue("FirstName", model.FirstName);
            command.Parameters.AddWithValue("LastName", model.LastName);
            command.Parameters.AddWithValue("NationalCode", model.NationalCode);
            command.Parameters.AddWithValue("Email", model.Email);
            command.Parameters.AddWithValue("DOB", model.DOB);
            command.Parameters.AddWithValue("IsActive", model.IsActive);
            command.Parameters.AddWithValue("Address", model.Address);
            command.Connection = conn;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();

        }


        public void CreateSP(Customer model)
        {
            var conn = new SqlConnection(connString);
            var command = new SqlCommand();

            command.CommandText = "[usp_CustomerInsert]";
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("FirstName", model.FirstName);
            command.Parameters.AddWithValue("LastName", model.LastName);
            command.Parameters.AddWithValue("NationalCode", model.NationalCode);
            command.Parameters.AddWithValue("Email", model.Email);
            command.Parameters.AddWithValue("DOB", model.DOB);
            command.Parameters.AddWithValue("IsActive", model.IsActive);
            command.Parameters.AddWithValue("Address", model.Address);
            command.Connection = conn;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();

        }


        public List<Customer> Read()
        {
            var result = new List<Customer>();

            var conn = new SqlConnection(connString);
            var command = new SqlCommand("SELECT * FROM [dbo].[Customer]", conn);
            conn.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new Customer
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Email = reader["Email"].ToString(),
                    Address = reader["Address"].ToString(),
                    NationalCode = reader["NationalCode"].ToString(),
                    DOB = Convert.ToDateTime(reader["DOB"]),
                    IsActive = Convert.ToBoolean(reader["IsActive"]),                    
                }); ;

            }
            conn.Close();
            return result;
        }

        public void Delete(int id)
        {
            var conn = new SqlConnection(connString);
            //var command = new SqlCommand("DELETE [dbo].[Customer] WHERE Id = @Id", conn);

            var command = new SqlCommand("[dbo].[usp_CustomerDelete]", conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            

            command.Parameters.AddWithValue("Id", id);
            conn.Open();
            command.ExecuteNonQuery();            
            conn.Close();            
        }

        public Customer GetById(int Id)
        {
            var conn = new SqlConnection(connString);

            var command = new SqlCommand("[dbo].[usp_CustomerSelect]", conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("Id", Id);
            conn.Open();

            var reader = command.ExecuteReader();

            if (reader.Read())
            {
                return new Customer
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Email = reader["Email"].ToString(),
                    Address = reader["Address"].ToString(),
                    NationalCode = reader["NationalCode"].ToString(),
                    DOB = Convert.ToDateTime(reader["DOB"]),
                    IsActive = Convert.ToBoolean(reader["IsActive"]),
                };

            }
            conn.Close();
            return null;
        }

        internal void Update(Customer model)
        {
            var conn = new SqlConnection(connString);
            var command = new SqlCommand();

            command.CommandText = "[usp_CustomerUpdate]";
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("Id", model.Id);
            command.Parameters.AddWithValue("FirstName", model.FirstName);
            command.Parameters.AddWithValue("LastName", model.LastName);
            command.Parameters.AddWithValue("NationalCode", model.NationalCode);
            command.Parameters.AddWithValue("Email", model.Email);
            command.Parameters.AddWithValue("DOB", model.DOB);
            command.Parameters.AddWithValue("IsActive", model.IsActive);
            command.Parameters.AddWithValue("Address", model.Address);
            command.Connection = conn;

            //Reflection 

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();


            //OBject-Releation Mapping - ORM
            //Micro Framework: Dapper
        }
    }
}
