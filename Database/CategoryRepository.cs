using System;
using System.Collections.Generic;
using System.Data.SQLite;
using TrackBack.Models;

namespace TrackBack.Database
{
    public class CategoryRepository : BaseRepository
    {
        #region Read Operations

        // all categories for dropdown list
        public List<Category> GetAllCategories()
        {
            string sql = @"
                SELECT CategoryID, CategoryName
                FROM Categories
                ORDER BY CategoryName";

            return ExecuteList(sql, reader => MapCategoryFromReader(reader));
        }


        #endregion


        #region Private Mapper

        // Database row to Category object
        private Category MapCategoryFromReader(SQLiteDataReader reader)
        {
            return new Category
            {
                CategoryID = GetInt(reader, "CategoryID"),
                CategoryName = GetString(reader, "CategoryName")
            };
        }
        #endregion
    }
}