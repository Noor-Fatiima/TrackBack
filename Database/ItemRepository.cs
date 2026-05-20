using System;
using System.Collections.Generic;
using System.Data.SQLite;
using TrackBack.Models;

namespace TrackBack.Database
{
    public class ItemRepository : BaseRepository
    {
        // Base SELECT query — used in all read methods
        // CategoryName, LocationName, ReportedByName from JOIN
        private string BaseQuery = @"
            SELECT i.ItemID, i.UserID, i.CategoryID, i.LocationID,
                   i.ItemTitle, i.Description, i.ItemType,
                   i.DateOccurred, i.DateReported,i.Status,
                   c.CategoryName, l.LocationName,
                   u.FullName AS ReportedByName
            FROM Items i
            JOIN Categories c ON i.CategoryID = c.CategoryID
            JOIN Locations  l ON i.LocationID = l.LocationID
            JOIN Users      u ON i.UserID     = u.UserID";

        #region Read Operations

        // Get all active items — use in frmSearchItems ... claimed items do not show in search
        public List<Item> GetAllItems()
        {
            string sql = BaseQuery +
                " WHERE i.Status = 'Active'" +
                " ORDER BY i.DateReported DESC";

            return ExecuteList(sql, reader => MapItemFromReader(reader));
        }

        // Get items by specific user — use in dashboard 
        public List<Item> GetItemsByUserID(int userID)
        {
            string sql = BaseQuery +
                " WHERE i.UserID = @userID" +
                " ORDER BY i.DateReported DESC";

            var parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@userID", userID)
            };

            return ExecuteList(sql, reader => MapItemFromReader(reader), parameters);
        }

        // Get only Lost items — admin panel Tab 2
        public List<Item> GetLostItems()
        {
            string sql = BaseQuery +
                " WHERE i.ItemType = 'Lost'" +
                " AND   i.Status   = 'Active'" +
                " ORDER BY i.DateReported DESC";

            return ExecuteList(sql, reader => MapItemFromReader(reader));
        }

        // Get only Found items — admin panel Tab 3
        public List<Item> GetFoundItems()
        {
            string sql = BaseQuery +
                " WHERE i.ItemType = 'Found'" +
                " AND   i.Status   = 'Active'" +
                " ORDER BY i.DateReported DESC";

            return ExecuteList(sql, reader => MapItemFromReader(reader));
        }

        // Search by keyword in title or description — frmSearchItems
        public List<Item> SearchItems(string keyword)
        {
            string sql = BaseQuery + @"
                WHERE i.Status = 'Active'
                AND  (i.ItemTitle   LIKE @keyword    OR    i.Description LIKE @keyword )
                ORDER BY i.DateReported DESC";

            var parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@keyword", $"%{keyword}%")
            };

            return ExecuteList(sql, reader => MapItemFromReader(reader), parameters);
        }


        #endregion

        #region Write Operations

        // New item save  — call from frmAddItem 
        public bool AddItem(Item item)
        {
            string sql = @"
                INSERT INTO Items
                    (UserID, CategoryID, LocationID, ItemTitle,
                     Description, ItemType, DateOccurred,
                     Status)
                VALUES
                    (@userID, @categoryID, @locationID, @itemTitle,
                     @description, @itemType, @dateOccurred,
                     @status)";

            var parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@userID",      item.UserID),
                new SQLiteParameter("@categoryID",  item.CategoryID),
                new SQLiteParameter("@locationID",  item.LocationID),
                new SQLiteParameter("@itemTitle",   item.ItemTitle),
                new SQLiteParameter("@description", string.IsNullOrEmpty(item.Description) ? (object)DBNull.Value
                                                   : item.Description),
                new SQLiteParameter("@itemType",    item.ItemType),
                new SQLiteParameter("@dateOccurred",item.DateOccurred),
                new SQLiteParameter("@status",      item.Status),
            };

            int rowsAffected = ExecuteNonQuery(sql, parameters);

            if (rowsAffected > 0)
            {
                // set new row's ID in item
                item.ItemID = (int)GetLastInsertId();
                return true;
            }

            return false;
        }

        // update Item status  — when Admin approve claim
        // Active to Claimed to Closed
        public bool UpdateItemStatus(int itemID, string status)
        {
            string sql = @"
                UPDATE Items
                SET Status = @status
                WHERE ItemID = @itemID";

            var parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@status", status),
                new SQLiteParameter("@itemID", itemID)
            };

            int rowsAffected = ExecuteNonQuery(sql, parameters);
            return rowsAffected > 0;
        }


        // UPDATE — update item details
        // only that user can update who created the item — check in WHERE clause
        public bool UpdateItem(Item item)
        {
            string sql = @"
            UPDATE Items
            SET CategoryID   = @categoryID,
            LocationID   = @locationID,
            ItemTitle    = @itemTitle,
            Description  = @description,
            ItemType     = @itemType,
            DateOccurred = @dateOccurred
            WHERE ItemID  = @itemID            
            AND   UserID  = @userID";         //only  update your own item not others — security check

            var parameters = new SQLiteParameter[]
            {
                  new SQLiteParameter("@categoryID",   item.CategoryID),
                  new SQLiteParameter("@locationID",   item.LocationID),
                  new SQLiteParameter("@itemTitle",    item.ItemTitle),
                  new SQLiteParameter("@description",  string.IsNullOrEmpty(item.Description)
                                             ? (object)DBNull.Value
                                             : item.Description),
                  new SQLiteParameter("@itemType",     item.ItemType),
                  new SQLiteParameter("@dateOccurred", item.DateOccurred),
                  new SQLiteParameter("@itemID",       item.ItemID),
                  new SQLiteParameter("@userID",       item.UserID)
            };

            return ExecuteNonQuery(sql, parameters) > 0;
        }

        // Item delete — Admin only
        // delete only if no one claimed it
        public bool DeleteItem(int itemID)
        {
            // Safety check — if claims exist don't delete
            string checkSql = @"
                SELECT COUNT(*) FROM Claims
                WHERE ItemID = @itemID";

            var checkParams = new SQLiteParameter[]
            {
                new SQLiteParameter("@itemID", itemID)
            };

            long claimCount = Convert.ToInt64( ExecuteScalar (checkSql, checkParams));

            if (claimCount > 0)
                return false; // Claims exist — delete block

            string sql = "DELETE FROM Items WHERE ItemID = @itemID";

            var parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@itemID", itemID)
            };

            int rowsAffected = ExecuteNonQuery(sql, parameters);
            return rowsAffected > 0;
        }

        #endregion

        #region Count Operations

        // Total lost items — admin dashboard stat box
        public int GetLostItemCount()
        {
            return (int)Convert.ToInt64(ExecuteScalar(
                "SELECT COUNT(*) FROM Items WHERE ItemType = 'Lost'"));
        }

        // Total found items — admin dashboard stat box
        public int GetFoundItemCount()
        {
            return (int)Convert.ToInt64(ExecuteScalar(
                "SELECT COUNT(*) FROM Items WHERE ItemType = 'Found'"));
        }

        // Claimed items count — admin dashboard stat box
        public int GetClaimedItemCount()
        {
            return (int)Convert.ToInt64(ExecuteScalar(
                "SELECT COUNT(*) FROM Items WHERE Status = 'Claimed'"));
        }

        #endregion

        #region Private Mapper

        // Database row to item object conversion
        // every column's name should match SQL query
        private Item MapItemFromReader(SQLiteDataReader reader)
        {
            return new Item
            {
                ItemID = GetInt(reader, "ItemID"),
                UserID = GetInt(reader, "UserID"),
                CategoryID = GetInt(reader, "CategoryID"),
                LocationID = GetInt(reader, "LocationID"),
                ItemTitle = GetString(reader, "ItemTitle"),
                Description = GetString(reader, "Description"),
                ItemType = GetString(reader, "ItemType"),
                DateOccurred = GetDateTime(reader, "DateOccurred"), 
                DateReported = GetDateTime(reader, "DateReported"),
                Status = GetString(reader, "Status"),
                // Navigation properties — JOIN se aate hain
                CategoryName = GetString(reader, "CategoryName"),
                LocationName = GetString(reader, "LocationName"),
                ReportedByName = GetString(reader, "ReportedByName")
            };
        }

        #endregion

        
    }
}