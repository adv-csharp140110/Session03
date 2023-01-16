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

    }
}
