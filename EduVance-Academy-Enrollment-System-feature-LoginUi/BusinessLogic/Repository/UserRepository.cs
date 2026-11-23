using System;
using System.Data;
using System.Data.SqlClient;
using EduVance.Models;

namespace EduVance.BusinessLogic.Repository
{
    public sealed class UserRepository
    {
        private readonly string connectionString;

        public UserRepository(string connectionString)
        {
            if (String.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("Missing EduVance connection string.");

            this.connectionString = connectionString;
        }

        public AuthenticatedUser Authenticate(string username, string password)
        {
            const string sql = @"
                SELECT TOP (1) Username, UserRole
                FROM dbo.AppUsers
                WHERE Username = @Username
                  AND IsActive = 1
                  AND UserRole IN ('Admin', 'Registrar', 'Cashier')
                  AND PasswordHash = HASHBYTES(
                      'SHA2_256',
                      PasswordSalt + CONVERT(VARBINARY(MAX), @Password)
                  )";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.Add("@Username", SqlDbType.NVarChar, 50).Value = username;
                command.Parameters.Add("@Password", SqlDbType.NVarChar, 200).Value = password;
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read()) return null;
                    return new AuthenticatedUser
                    {
                        Username = reader.GetString(0),
                        Role = reader.GetString(1)
                    };
                }
            }
        }
    }
}
