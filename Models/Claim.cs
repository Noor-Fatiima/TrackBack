using System;

namespace TrackBack.Models
{
    public class Claim
    {
        public int ClaimID { get; set; }
        public int ItemID { get; set; }
        public int ClaimedByID { get; set; }
        public string ClaimMessage { get; set; } = string.Empty;
        public string ProofDescription { get; set; } = string.Empty;
        public DateTime ClaimDate { get; set; } = DateTime.Now;
        public string Status { get; set; } = "Pending";
        public string AdminNote { get; set; } = string.Empty;
        public DateTime? ResolvedDate { get; set; }

        // Navigation properties - display ke liye
        public string ItemTitle { get; set; } = string.Empty;
        public string ClaimedByName { get; set; } = string.Empty;

    }
}