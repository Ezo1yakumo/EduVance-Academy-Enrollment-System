
using System;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;

namespace Login_UI
{
    public static class DatabaseInitializer
    {
        public static void Initialize()
        {
            var appBuilder = new SqlConnectionStringBuilder(
                DatabaseConnection.ConnectionString);

            appBuilder.InitialCatalog = "EduVance";

            var masterBuilder = new SqlConnectionStringBuilder(
                appBuilder.ConnectionString);

            masterBuilder.InitialCatalog = "master";

            using (var connection =
                new SqlConnection(masterBuilder.ConnectionString))
            {
                connection.Open();

                using (var check = new SqlCommand(
                    "SELECT DB_ID(N'EduVance')", connection))
                {
                    object result = check.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                    {
                        using (var create = new SqlCommand(
                            "CREATE DATABASE [EduVance]", connection))
                        {
                            create.CommandTimeout = 120;
                            create.ExecuteNonQuery();
                        }
                    }
                }
            }

            using (var connection =
                new SqlConnection(appBuilder.ConnectionString))
            {
                connection.Open();

                using (var check = new SqlCommand(
                    "SELECT COUNT(*) FROM sys.tables " +
                    "WHERE is_ms_shipped = 0", connection))
                {
                    int count = Convert.ToInt32(
                        check.ExecuteScalar());

                    if (count > 0)
                    {
                        using (var required = new SqlCommand(@"
                            SELECT COUNT(*)
                            FROM sys.tables
                            WHERE schema_id = SCHEMA_ID('dbo')
                            AND name IN
                            (
                                'Students',
                                'Sections',
                                'Enrollments',
                                'Assessments',
                                'AssessmentPayments',
                                'AppUsers'
                            )", connection))
                        {
                            int found = Convert.ToInt32(
                                required.ExecuteScalar());

                            if (found != 6)
                            {
                                throw new Exception(
                                    "The existing EduVance database " +
                                    "is missing required tables. " +
                                    "Please check its schema.");
                            }
                        }

                        return;
                    }
                }

                string folder =
                    AppDomain.CurrentDomain.BaseDirectory;

                string file = Path.Combine(
                    folder, "DB", "01_Schema.sql");

                if (!File.Exists(file))
                {
                    file = Path.Combine(
                        folder, "01_Schema.sql");
                }

                if (!File.Exists(file))
                {
                    throw new FileNotFoundException(
                        "Database schema file not found.",
                        file);
                }

                string script = File.ReadAllText(file);

                if (Regex.IsMatch(script,
                    @"(?im)^[ \t]*(CREATE|DROP|ALTER)[ \t]+DATABASE\b"))
                {
                    throw new Exception(
                        "01_Schema.sql contains database-level " +
                        "creation or modification commands.");
                }

                string[] batches = Regex.Split(
                    script,
                    @"(?im)^[ \t]*GO[ \t]*(?:--[^\r\n]*)?\r?$");


                foreach (string batch in batches)
                {
                    if (string.IsNullOrWhiteSpace(batch))
                        continue;

                    using (var command = new SqlCommand(batch, connection))
                    {
                        command.CommandTimeout = 120;
                        command.ExecuteNonQuery();
                    }
                }

                // Run seed data AFTER all schema batches finish
                string seedFile = Path.Combine(
                    folder, "DB", "02_SeedData.sql");

                if (!File.Exists(seedFile))
                {
                    throw new FileNotFoundException(
                        "Seed data file not found.",
                        seedFile);
                }

                string seedScript = File.ReadAllText(seedFile);

                string[] seedBatches = Regex.Split(
                    seedScript,
                    @"(?im)^[ \t]*GO[ \t]*(?:--[^\r\n]*)?\r?$");

                foreach (string seedBatch in seedBatches)
                {
                    if (string.IsNullOrWhiteSpace(seedBatch))
                        continue;

                    using (var seedCommand =
                        new SqlCommand(seedBatch, connection))
                    {
                        seedCommand.CommandTimeout = 120;
                        seedCommand.ExecuteNonQuery();
                    }
                }


            }

        }
            }
        }
    

