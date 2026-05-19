using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackBack.Database;
using TrackBack.Models;

namespace TrackBack.Forms
{
    public partial class frmSearchItems : Form
    {
        private readonly User _currentUser;
        private readonly ItemRepository _itemRepository;
        private readonly ClaimRepository _claimRepository;

        public frmSearchItems(User user)
        {
            InitializeComponent();
            _currentUser = user;
            _itemRepository = new ItemRepository();
            _claimRepository = new ClaimRepository();
            LoadAllItems();
        }

        private void LoadAllItems()
        {
            try
            {
                var items = _itemRepository.GetAllItems();
                dgvItems.DataSource = null;
                dgvItems.DataSource = items;
                dgvItems.AllowUserToAddRows = false;
                dgvItems.ReadOnly = true;
                dgvItems.RowHeadersVisible = false;
                dgvItems.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                foreach (DataGridViewColumn col in dgvItems.Columns)
                    col.Visible = false;

                ShowCol("ItemID", "ID", 50);
                ShowCol("ItemType", "Type", 70);
                ShowCol("CategoryName", "Category", 120);
                ShowCol("ItemTitle", "Title", 200);
                ShowCol("LocationName", "Location", 120);
                ShowCol("Description", "Description", 180);
                ShowCol("Status", "Status", 80);
                ShowCol("DateOccurred", "Date", 100);

                if (dgvItems.Columns["DateOccurred"] != null)
                    dgvItems.Columns["DateOccurred"]
                        .DefaultCellStyle.Format = "dd-MMM-yyyy";

                foreach (DataGridViewRow row in dgvItems.Rows)
                {
                    string type = row.Cells["ItemType"]? .Value?.ToString();
                    if (type == "Lost")
                        row.DefaultCellStyle.BackColor =
                            Color.FromArgb(255, 226, 226);
                    else if (type == "Found")
                        row.DefaultCellStyle.BackColor =
                            Color.FromArgb(224, 242, 254);
                }

                lblStatus.Text = $"Total: {items.Count} items";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ShowCol(string col, string header, int width)
        {
            if (dgvItems.Columns[col] != null)
            {
                dgvItems.Columns[col].Visible = true;
                dgvItems.Columns[col].HeaderText = header;
                dgvItems.Columns[col].Width = width;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var results = _itemRepository.SearchItems(
                    txtSearch.Text.Trim());
                dgvItems.DataSource = null;
                dgvItems.DataSource = results;
                lblStatus.Text = $"Total: {results.Count} items";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadAllItems();
        }

        private void btnClaim_Click(object sender, EventArgs e)
        {
            if (dgvItems.CurrentRow == null)
            {
                MessageBox.Show("Please select an item.");
                return;
            }

            var item = dgvItems.CurrentRow.DataBoundItem as Item;
            if (item == null) return;

            if (item.ItemType != "Found")
            {
                MessageBox.Show("You can only claim Found items.");
                return;
            }

            if (item.UserID == _currentUser.UserID)
            {
                MessageBox.Show("You cannot claim your own item.");
                return;
            }

            if (_claimRepository.HasUserAlreadyClaimed(
                item.ItemID, _currentUser.UserID))
            {
                MessageBox.Show("Already claimed this item.");
                return;
            }

            string msg = Microsoft.VisualBasic.Interaction.InputBox(
                "Describe why this is your item:",
                "Claim Item", "");

            if (string.IsNullOrWhiteSpace(msg)) return;

            try
            {
                var claim = new Claim
                {
                    ItemID = item.ItemID,
                    ClaimedByID = _currentUser.UserID,
                    ClaimMessage = msg,
                    Status = "Pending"
                };

                if (_claimRepository.AddClaim(claim))
                    MessageBox.Show("Claim submitted! Admin will review.");
                else
                    MessageBox.Show("Failed to submit claim.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

