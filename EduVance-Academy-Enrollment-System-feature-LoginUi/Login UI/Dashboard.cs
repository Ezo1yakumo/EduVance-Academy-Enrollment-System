using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace BusinessLogic.Repository
{
    public class EnrollmentMonth
    {
        public int MonthNumber { get; set; }
        public int EnrollmentCount { get; set; }
    }

    public class DashboardSummary
    {
        public int TotalStudents { get; set; }
        public int TotalEnrollments { get; set; }
        public int ActiveSections { get; set; }
        public List<EnrollmentMonth> MonthlyEnrollments { get; set; }
            = new List<EnrollmentMonth>();
    }

    public class DashboardRepository
    {
        private readonly string _connectionString =
            ConfigurationManager.ConnectionStrings["EduVanceDb"].ConnectionString;

        public DashboardSummary GetSummary(string schoolYear)
        {
            var result = new DashboardSummary();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                const string totalsSql = @"
                    SELECT
                        (SELECT COUNT(*) FROM dbo.Students) AS TotalStudents,
                        (SELECT COUNT(*) FROM dbo.Enrollments
                         WHERE SchoolYear = @SchoolYear) AS TotalEnrollments,
                        (SELECT COUNT(*) FROM dbo.Sections
                         WHERE IsActive = 1) AS ActiveSections;";

                using (var command = new SqlCommand(totalsSql, connection))
                {
                    command.Parameters.AddWithValue("@SchoolYear", schoolYear);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result.TotalStudents = Convert.ToInt32(reader["TotalStudents"]);
                            result.TotalEnrollments = Convert.ToInt32(reader["TotalEnrollments"]);
                            result.ActiveSections = Convert.ToInt32(reader["ActiveSections"]);
                        }
                    }
                }

                const string chartSql = @"
                    SELECT MONTH(EnrollmentDate) AS MonthNumber,
                           COUNT(*) AS EnrollmentCount
                    FROM dbo.Enrollments
                    WHERE SchoolYear = @SchoolYear
                    GROUP BY MONTH(EnrollmentDate)
                    ORDER BY MonthNumber;";

                using (var command = new SqlCommand(chartSql, connection))
                {
                    command.Parameters.AddWithValue("@SchoolYear", schoolYear);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.MonthlyEnrollments.Add(new EnrollmentMonth
                            {
                                MonthNumber = Convert.ToInt32(reader["MonthNumber"]),
                                EnrollmentCount = Convert.ToInt32(reader["EnrollmentCount"])
                            });
                        }
                    }
                }
            }

            return result;
        }
    }
}