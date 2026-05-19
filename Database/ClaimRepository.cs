using System;
using System.Collections.Generic;
using System.Data.SQLite;
using TrackBack.Models;

namespace TrackBack.Database
{
    public class ClaimRepository : BaseRepository
    {
        // Base query — item title and username from JOIN 
        private string BaseQuery = @"
            SELECT cl.ClaimID, cl.ItemID, cl.ClaimedByID,
                   cl.ClaimMessage, cl.ProofDescription,
                   cl.ClaimDate, cl.Status,
                   cl.AdminNote, cl.ResolvedDate,
                   i.ItemTitle,
                   u.FullName AS ClaimedByName
            FROM Claims cl
            JOIN Items i ON cl.ItemID      = i.ItemID
            JOIN Users u ON cl.ClaimedByID = u.UserID";

        #region Read Operations

        // READ — all claims of one user — dashboard
        public List<Claim> GetClaimsByUserID(int userID)
        {
            string sql = BaseQuery +
                " WHERE cl.ClaimedByID = @userID " +
                "ORDER BY cl.ClaimDate DESC";

            var p = new SQLiteParameter[]
            { new SQLiteParameter("@userID", userID) };

            return ExecuteList(sql, reader => MapClaimFromReader(reader), p);
        }

        // READ — pending claims — for admin review 
        public List<Claim> GetPendingClaims()
        {
            return ExecuteList(
                BaseQuery + " WHERE cl.Status = 'Pending' ORDER BY cl.ClaimDate ASC",
                reader => MapClaimFromReader(reader));
        }

        #endregion

        #region Write Operations

        // CREATE — submit claim  — frmSearchItems
        // one user can claim one item, only one time
        public bool AddClaim(Claim claim)
        {
            if (HasUserAlreadyClaimed(claim.ItemID, claim.ClaimedByID))
                return false;

            string sql = @"
                INSERT INTO Claims
                    (ItemID, ClaimedByID, ClaimMessage,
                     ProofDescription, Status)
                VALUES
                    (@itemID, @claimedByID, @claimMessage,
                     @proof, 'Pending')";

            var p = new SQLiteParameter[]
            {
                new SQLiteParameter("@itemID",      claim.ItemID),
                new SQLiteParameter("@claimedByID", claim.ClaimedByID),
                new SQLiteParameter("@claimMessage",claim.ClaimMessage),
                new SQLiteParameter("@proof",       string.IsNullOrEmpty(claim.ProofDescription)
                                                   ? (object)DBNull.Value : claim.ProofDescription)
            };

            if (ExecuteNonQuery(sql, p) > 0)
            {
                claim.ClaimID = (int)GetLastInsertId();
                return true;
            }
            return false;
        }

        // UPDATE — approve claim — admin only
        public bool ApproveClaim(int claimID, string adminNote)
        {
            string sql = @"
                UPDATE Claims
                SET Status       = 'Approved',
                    AdminNote    = @note,
                    ResolvedDate = @date
                WHERE ClaimID = @claimID";

            var p = new SQLiteParameter[]
            {
                new SQLiteParameter("@note",    adminNote),
                new SQLiteParameter("@date",    DateTime.Now),
                new SQLiteParameter("@claimID", claimID)
            };

            return ExecuteNonQuery(sql, p) > 0;
        }

        // UPDATE — reject claim  — admin only
        public bool RejectClaim(int claimID, string adminNote)
        {
            string sql = @"
                UPDATE Claims
                SET Status       = 'Rejected',
                    AdminNote    = @note,
                    ResolvedDate = @date
                WHERE ClaimID = @claimID";

            var p = new SQLiteParameter[]
            {
                new SQLiteParameter("@note",    adminNote),
                new SQLiteParameter("@date",    DateTime.Now),
                new SQLiteParameter("@claimID", claimID)
            };

            return ExecuteNonQuery(sql, p) > 0;
        }

        // DELETE — delete claim  — admin only
        public bool DeleteClaim(int claimID)
        {
            string sql = "DELETE FROM Claims WHERE ClaimID = @claimID";
            var p = new SQLiteParameter[]
            { new SQLiteParameter("@claimID", claimID) };

            return ExecuteNonQuery(sql, p) > 0;
        }

        #endregion

        #region Helper Methods

        // Duplicate claim check — one user can't claim on same item 2 times
        public bool HasUserAlreadyClaimed(int itemID, int userID)
        {
            string sql = @"
                SELECT COUNT(*) FROM Claims
                WHERE ItemID = @itemID AND ClaimedByID = @userID";

            var p = new SQLiteParameter[]
            {
                new SQLiteParameter("@itemID", itemID),
                new SQLiteParameter("@userID", userID)
            };

            return Convert.ToInt64(ExecuteScalar(sql, p)) > 0;
        }

        // Pending claims count — admin dashboard
        public int GetPendingClaimCount()
        {
            return (int)Convert.ToInt64(ExecuteScalar("SELECT COUNT(*) FROM Claims WHERE Status = 'Pending'"));
        }

        // Approved claims = recovered items — admin dashboard
        public int GetRecoveredItemCount()
        {
            return (int)Convert.ToInt64(ExecuteScalar("SELECT COUNT(*) FROM Claims WHERE Status = 'Approved'"));
        }

        #endregion

        #region Private Mapper

        // Database row to Claim object
        private Claim MapClaimFromReader(SQLiteDataReader reader)
        {
            return new Claim
            {
                ClaimID = GetInt(reader, "ClaimID"),
                ItemID = GetInt(reader, "ItemID"),
                ClaimedByID = GetInt(reader, "ClaimedByID"),
                ClaimMessage = GetString(reader, "ClaimMessage"),
                ProofDescription = GetString(reader, "ProofDescription"),
                ClaimDate = GetDateTime(reader, "ClaimDate"),
                Status = GetString(reader, "Status"),
                AdminNote = GetString(reader, "AdminNote"),
                // Nullable DateTime — null in pending claims 
                ResolvedDate = reader.IsDBNull(reader.GetOrdinal("ResolvedDate"))
                                   ? null
                                   : GetDateTime(reader, "ResolvedDate"),
                ItemTitle = GetString(reader, "ItemTitle"),
                ClaimedByName = GetString(reader, "ClaimedByName"),

            };
        }

        #endregion
    }
}