using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace TrackBack.Database
{
    public abstract class BaseRepository //can inherit this class to other repository classes to avoid code duplication 
    {
        protected SQLiteConnection GetConnection()
        {
            return DBConnection.GetConnection();
        }

        // for INSERT, UPDATE, DELETE when we don't expect any result back, just how many rows affected
        protected int ExecuteNonQuery(string sql, SQLiteParameter[]? parameters = null)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(sql, conn)) //this object execute sql
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters); //AddRange method allows to add multiple parameters to the command in one call
                    return cmd.ExecuteNonQuery(); //returns how many rows affected
                }
            }
        }

        // for Single value  — COUNT etc
        // object (generic type)  caller can cast it to int, string etc as needed
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

        // for DataGridView - datatable is like excel sheet in memory , rows and columns
        protected DataTable ExecuteReader(string sql, SQLiteParameter[]? parameters = null)
        {
            var dt = new DataTable(); //empty table create
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);
                    using (var adapter = new SQLiteDataAdapter(cmd))
                        adapter.Fill(dt); //run query and fill the datatable with result
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

        // Multiple rows to List of objects - use in GetAllItems(), GetClaimsByUserID() etc
        protected List<T> ExecuteList<T>(string sql, Func<SQLiteDataReader, T> mapper, 
            SQLiteParameter[]? parameters = null)
        {
            var results = new List<T>(); // empty list create
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
            int i = r.GetOrdinal(col); //get column index number from column name
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
            return !r.IsDBNull(i) && r.GetBoolean(i); //not null and true
        }

        // Safe DateTime
        protected DateTime GetDateTime(SQLiteDataReader r, string col)
        {
            int i = r.GetOrdinal(col);
            return r.IsDBNull(i) ? DateTime.MinValue : DateTime.Parse(r.GetString(i)); //datetime is stored in text form so parse it
        }

        // after Insert gives new row's Id
        protected long GetLastInsertId()
        {
            object result = ExecuteScalar("SELECT last_insert_rowid();");
            return result != null ? Convert.ToInt64(result) : 0;
        }
    }
}