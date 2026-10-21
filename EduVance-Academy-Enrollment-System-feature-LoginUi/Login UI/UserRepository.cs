
using System.Data;
using System.Data.SqlClient;

namespace Login_UI
{
    public class UserRepository
    {
        public bool ValidateCredentials(
            string username, string password, string role)
        {
            string sql = @"
                SELECT COUNT(*)
                FROM dbo.AppUsers
                WHERE Username = @Username
                AND UserRole = @Role
                AND IsActive = 1
                AND PasswordHash = HASHBYTES(
                    'SHA2_256',
                    PasswordSalt +
                    CONVERT(VARBINARY(MAX), @Password)
                )";

            using (SqlConnection connection =
                new SqlConnection(DatabaseConnection.ConnectionString))
            using (SqlCommand command =
                new SqlCommand(sql, connection))
            {
                command.Parameters.Add(
                    "@Username", SqlDbType.NVarChar, 50)
                    .Value = username;

                command.Parameters.Add(
                    "@Password", SqlDbType.NVarChar, 200)
                    .Value = password;

                command.Parameters.Add(
                    "@Role", SqlDbType.NVarChar, 20)
                    .Value = role;

                connection.Open();

                return (int)command.ExecuteScalar() > 0;
            }
        }
    }
}
