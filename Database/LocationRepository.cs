using System;
using System.Collections.Generic;
using System.Data.SQLite;
using TrackBack.Models;

namespace TrackBack.Database
{
    public class LocationRepository : BaseRepository
    {
        #region Read Operations

        // all location for dropdown list - frmddItem and frmSearchItems
        public List<Location> GetAllLocations()
        {
            string sql = @"
                SELECT LocationID, LocationName
                FROM Locations
                ORDER BY LocationName";

            return ExecuteList(sql, reader => MapLocationFromReader(reader));
        }


        #endregion


        #region Private Mapper

        // Database row to Location object
        private Location MapLocationFromReader(SQLiteDataReader reader)
        {
            return new Location
            {
                LocationID = GetInt(reader, "LocationID"),
                LocationName = GetString(reader, "LocationName")
            };
        }

        #endregion
    }
}