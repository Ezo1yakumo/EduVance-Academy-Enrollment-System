using System;
using System.Data;
using System.Data.SqlClient;
using EduVance.Models;

namespace EduVance.BusinessLogic.Repository
{
    public sealed class StudentRepository
    {
        private readonly string connectionString;

        public StudentRepository(string connectionString)
        {
            if (String.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("Missing EduVance connection string.");
            this.connectionString = connectionString;
        }

        public DataTable Search(string nameFilter, string idFilter)
        {
            const string sql = @"
                SELECT StudentID, FullName, Gender, DateOfBirth,
                       Address, ContactNumber, EmailAddress
                FROM dbo.Students
                WHERE (@Name = '' OR FullName LIKE '%' + @Name + '%')
                  AND (@ID = '' OR CONVERT(NVARCHAR(20), StudentID) = @ID)
                ORDER BY StudentID DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connection))
            {
                adapter.SelectCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 150).Value = nameFilter ?? "";
                adapter.SelectCommand.Parameters.Add("@ID", SqlDbType.NVarChar, 20).Value = idFilter ?? "";
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public int Save(StudentRecord student)
        {
            bool inserting = student.StudentID == 0;
            string sql = inserting
                ? @"INSERT INTO dbo.Students
                    (FullName, Gender, DateOfBirth, Address, ContactNumber, EmailAddress)
                    VALUES (@FullName, @Gender, @DateOfBirth, @Address, @ContactNumber, @EmailAddress)"
                : @"UPDATE dbo.Students SET
                    FullName = @FullName, Gender = @Gender, DateOfBirth = @DateOfBirth,
                    Address = @Address, ContactNumber = @ContactNumber, EmailAddress = @EmailAddress
                    WHERE StudentID = @StudentID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.Add("@FullName", SqlDbType.NVarChar, 150).Value = student.FullName;
                command.Parameters.Add("@Gender", SqlDbType.NVarChar, 20).Value = student.Gender;
                command.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = student.DateOfBirth.Date;
                command.Parameters.Add("@Address", SqlDbType.NVarChar, 300).Value = student.Address;
                command.Parameters.Add("@ContactNumber", SqlDbType.NVarChar, 30).Value = student.ContactNumber;
                command.Parameters.Add("@EmailAddress", SqlDbType.NVarChar, 150).Value = student.EmailAddress;
                if (!inserting)
                    command.Parameters.Add("@StudentID", SqlDbType.Int).Value = student.StudentID;

                connection.Open();
                return command.ExecuteNonQuery();
            }
        }

        public int Delete(int studentId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(
                "DELETE FROM dbo.Students WHERE StudentID = @ID", connection))
            {
                command.Parameters.Add("@ID", SqlDbType.Int).Value = studentId;
                connection.Open();
                return command.ExecuteNonQuery();
            }
        }
    }
}
