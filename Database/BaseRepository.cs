using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace TrackBack.Database
{
    public abstract class BaseRepository
    {
        protected SQLiteConnection GetConnection()
        {
            return DBConnection.GetConnection();
        }

        // for INSERT, UPDATE, DELETE 
        protected int ExecuteNonQuery(string sql, SQLiteParameter[]? parameters = null)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // for Single value  — COUNT etc
        protected object ExecuteScalar(string sql, SQLiteParameter[]? parameters = null)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteScalar();
                }
            }
        }

        // for DataGridView 
        protected DataTable ExecuteReader(string sql, SQLiteParameter[]? parameters = null)
        {
            var dt = new DataTable();
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);
                    using (var adapter = new SQLiteDataAdapter(cmd))
                        adapter.Fill(dt);
                }
            }
            return dt;
        }

        // one row to one object
        protected T ExecuteSingle<T>(string sql, Func<SQLiteDataReader, T> mapper,
            SQLiteParameter[]? parameters = null)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            return mapper(reader);
                        return default(T)!;
                    }
                }
            }
        }

        // Multiple rows → List
        protected List<T> ExecuteList<T>(string sql, Func<SQLiteDataReader, T> mapper, 
            SQLiteParameter[]? parameters = null)
        {
            var results = new List<T>();
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                            results.Add(mapper(reader));
                }
            }
            return results;
        }

        // Safe string
        protected string GetString(SQLiteDataReader r, string col)
        {
            int i = r.GetOrdinal(col);
            return r.IsDBNull(i) ? string.Empty : r.GetString(i);
        }

        // Safe int
        protected int GetInt(SQLiteDataReader r, string col)
        {
            int i = r.GetOrdinal(col);
            return r.IsDBNull(i) ? 0 : r.GetInt32(i);
        }

        // Safe bool
        protected bool GetBoolean(SQLiteDataReader r, string col)
        {
            int i = r.GetOrdinal(col);
            return !r.IsDBNull(i) && r.GetBoolean(i);
        }

        // Safe DateTime
        protected DateTime GetDateTime(SQLiteDataReader r, string col)
        {
            int i = r.GetOrdinal(col);
            return r.IsDBNull(i) ? DateTime.MinValue : DateTime.Parse(r.GetString(i));
        }

        // after Insert new row's Id
        protected long GetLastInsertId()
        {
            object result = ExecuteScalar("SELECT last_insert_rowid();");
            return result != null ? Convert.ToInt64(result) : 0;
        }
    }
}