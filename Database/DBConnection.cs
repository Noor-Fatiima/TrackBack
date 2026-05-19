using System;
using System.IO;
using System.Data.SQLite;
using BCrypt.Net;

namespace TrackBack.Database
{
    public static class DBConnection
    {
        private static string _databasePath = string.Empty;
        private static string _connectionString = string.Empty;

        public static string DatabasePath
        {
            get
            {
                if (string.IsNullOrEmpty(_databasePath))
                {
                    string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    _databasePath = Path.Combine(baseDirectory, "Database", "db.sqlite");
                }
                return _databasePath;
            }
        }

        public static string ConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(_connectionString))
                {
                    _connectionString = $"Data Source={DatabasePath};" + "Version=3;FailIfMissing=True;";
                }
                return _connectionString;
            }
        }

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(ConnectionString);
        }

        public static bool TestConnection()
        {
            try
            {
                if (!File.Exists(DatabasePath))
                    return false;

                using (var conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static void SeedAdminIfNotExists()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();

                    // Check admin already present or not
                    string checkSql = "SELECT COUNT(*) FROM Users WHERE Email = 'a.dmin@gmail.com'";
                    using (var checkCmd = new SQLiteCommand(checkSql, conn))
                    {
                        long count = Convert.ToInt64(checkCmd.ExecuteScalar());

                        if (count == 0)
                        {
                            // Admin not present then create it
                            string hash = BCrypt.Net.BCrypt.HashPassword("admin123", 11);

                            string insertSql = @"INSERT INTO Users 
                        (FullName, Email, Phone, Department, PasswordHash, Role)
                        VALUES 
                        ('Administrator', 'a.dmin@gmail.com', '0300-0000000',
                         'Computer Science', @hash, 'Admin')";

                            using (var insertCmd = new SQLiteCommand(insertSql, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@hash", hash);
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch { }
        }

    }
}