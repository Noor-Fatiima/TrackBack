using System;
using System.IO;
using System.Data.SQLite;
using BCrypt.Net;

namespace TrackBack.Database
{
    public static class DBConnection //manage sqlite connection and  path
    {
        //at first it is empty but when we call DatabasePath property it will be initialized and stored in _databasePath variable for future use
        private static string _databasePath = string.Empty; 
        private static string _connectionString = string.Empty;

        public static string DatabasePath
        {
            get
            {
                if (string.IsNullOrEmpty(_databasePath))
                {
                    //get the base directory of the application, which is the folder where the executable is located. This is useful for constructing paths to resources that are relative to the application's location.
                    string baseDirectory = AppDomain.CurrentDomain.BaseDirectory; 
                    _databasePath = Path.Combine(baseDirectory, "Database", "db.sqlite");//combine exe folder "Database" subfolder and "db.sqlite" file 
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
                    //FailIfMissing=True ensures that if the database file does not exist then fail connection.
                    //if it is false then new blank database is created
                    _connectionString = $"Data Source={DatabasePath};" + "Version=3;FailIfMissing=True;";
                }
                return _connectionString;
            }
        }

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(ConnectionString); //only make object does not open file
        }

        public static bool TestConnection()
        {
            try
            {
                if (!File.Exists(DatabasePath))
                    return false;

                using (var conn = GetConnection()) //using statement ensures that the connection is automatically and properly disposed of after use, even if an exception occurs. 
                {
                    conn.Open();//open sqlite file
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
                    using (var checkCmd = new SQLiteCommand(checkSql, conn)) //this object execute SQL
                    {
                        long count = Convert.ToInt64(checkCmd.ExecuteScalar());

                        if (count == 0)
                        {
                            // Admin not present then create it
                            string hash = BCrypt.Net.BCrypt.HashPassword("admin123", 11);

                            string insertSql = @"INSERT INTO Users (FullName, Email, Phone, 
                                                   Department, PasswordHash, Role)
                                               VALUES 
                                               ('Administrator', 'a.dmin@gmail.com', '0300-0000000',
                                               'Computer Science', @hash, 'Admin')";

                            using (var insertCmd = new SQLiteCommand(insertSql, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@hash", hash);
                                insertCmd.ExecuteNonQuery(); //execute insert command to add admin user to database
                            }
                        }
                    }
                }
            }
            catch { }
        }

    }
}