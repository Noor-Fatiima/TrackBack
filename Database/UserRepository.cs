using System;
using System.Collections.Generic;
using System.Data.SQLite;
using TrackBack.Models;

namespace TrackBack.Database
{
    using BCrypt = BCrypt.Net.BCrypt;

    public class UserRepository : BaseRepository
    {
        #region Authentication

        // Login — verify email and password 
        // hash compared from BCrypt 
        public User Authenticate(string email, string password)
        {
            string sql = @"
                SELECT UserID, FullName, Email, Phone,
                       Department, PasswordHash, Role, RegistrationDate
                FROM Users WHERE Email = @email";

            var p = new SQLiteParameter[]
            { new SQLiteParameter("@email", email) };

            var user = ExecuteSingle(sql, reader => MapUserFromReader(reader), p);

            // verify password from BCrypt 
            if (user != null && BCrypt.Verify(password, user.PasswordHash))
                return user;

            return null;
        }

        #endregion

        #region CRUD Operations

        // CREATE — register new user
        public bool AddUser(User user, string plainPassword)
        {
            // Duplicate email check
            if (EmailExists(user.Email)) return false;

            // Hash Password   — plain text will not store
            string hash = BCrypt.HashPassword(plainPassword, 11);

            string sql = @"
                INSERT INTO Users
                    (FullName, Email, Phone, Department, PasswordHash, Role)
                VALUES
                    (@fullName, @email, @phone, @department, @hash, @role)";

            var p = new SQLiteParameter[]
            {
                new SQLiteParameter("@fullName",   user.FullName),
                new SQLiteParameter("@email",      user.Email),
                new SQLiteParameter("@phone",      string.IsNullOrEmpty(user.Phone)
                                                  ? (object)DBNull.Value : user.Phone),
                new SQLiteParameter("@department", string.IsNullOrEmpty(user.Department)
                                                  ? (object)DBNull.Value : user.Department),
                new SQLiteParameter("@hash",       hash),
                new SQLiteParameter("@role",       user.Role)
            };

            return ExecuteNonQuery(sql, p) > 0;
        }

        // READ — all users for admin
        public List<User> GetAllUsers()
        {
            string sql = @"
                SELECT UserID, FullName, Email, Phone,
                       Department, PasswordHash, Role, RegistrationDate
                FROM Users ORDER BY FullName";

            return ExecuteList(sql, reader => MapUserFromReader(reader));
        }

        // READ — from one userID
        public User GetUserByID(int userID)
        {
            string sql = @"
                SELECT UserID, FullName, Email, Phone,
                       Department, PasswordHash, Role, RegistrationDate
                FROM Users WHERE UserID = @userID";

            var p = new SQLiteParameter[]
            { new SQLiteParameter("@userID", userID) };

            return ExecuteSingle(sql, reader => MapUserFromReader(reader), p);
        }

        // UPDATE — update phone and department of user
        public bool UpdateUser(User user)
        {
            string sql = @"
                UPDATE Users
                SET Phone      = @phone,
                    Department = @department
                WHERE UserID   = @userID";

            var p = new SQLiteParameter[]
            {
                new SQLiteParameter("@phone",      string.IsNullOrEmpty(user.Phone)
                                                  ? (object)DBNull.Value : user.Phone),
                new SQLiteParameter("@department", string.IsNullOrEmpty(user.Department)
                                                  ? (object)DBNull.Value : user.Department),
                new SQLiteParameter("@userID",     user.UserID)
            };

            return ExecuteNonQuery(sql, p) > 0;
        }

        // DELETE — delete user
        // if Items present then don't delete
        public bool DeleteUser(int userID)
        {
            string checkSql = "SELECT COUNT(*) FROM Items WHERE UserID = @userID";
            var cp = new SQLiteParameter[]
            { new SQLiteParameter("@userID", userID) };

            if (Convert.ToInt64(ExecuteScalar(checkSql, cp)) > 0)
                return false;

            string sql = "DELETE FROM Users WHERE UserID = @userID";
            var p = new SQLiteParameter[]
            { new SQLiteParameter("@userID", userID) };

            return ExecuteNonQuery(sql, p) > 0;
        }

        #endregion

        #region Helper Methods

        // Email already registered?
        public bool EmailExists(string email)
        {
            string sql = "SELECT COUNT(*) FROM Users WHERE Email = @email";
            var p = new SQLiteParameter[]
            { new SQLiteParameter("@email", email) };

            return Convert.ToInt64(ExecuteScalar(sql, p)) > 0;
        }

        // Total users count — for admin dashboard
        public int GetUserCount()
        {
            return (int)Convert.ToInt64(ExecuteScalar("SELECT COUNT(*) FROM Users WHERE Role = 'User'"));
        }

        #endregion

        #region Private Mapper

        // Database row to User object
        private User MapUserFromReader(SQLiteDataReader reader)
        {
            return new User
            {
                UserID = GetInt(reader, "UserID"),
                FullName = GetString(reader, "FullName"),
                Email = GetString(reader, "Email"),
                Phone = GetString(reader, "Phone"),
                Department = GetString(reader, "Department"),
                PasswordHash = GetString(reader, "PasswordHash"),
                Role = GetString(reader, "Role"),
                RegistrationDate = GetDateTime(reader, "RegistrationDate")
            };
        }

        #endregion
    }
}