using System;

namespace TrackBack.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        public int UserID { get; set; }
        public int CategoryID { get; set; }
        public int LocationID { get; set; }
        public string ItemTitle { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ItemType { get; set; } = string.Empty;
        public DateTime DateOccurred { get; set; }
        public DateTime DateReported { get; set; } = DateTime.Now;
        public string Status { get; set; } = "Active";

        // Navigation properties - for display 
        public string CategoryName { get; set; } = string.Empty;
        public string LocationName { get; set; } = string.Empty;
        public string ReportedByName { get; set; } = string.Empty;
    }
}