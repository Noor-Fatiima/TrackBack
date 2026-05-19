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
    public partial class frmAdminPanel : Form
    {
        private readonly User _currentUser;
        private readonly ItemRepository _itemRepository;
        private readonly ClaimRepository _claimRepository;
        private readonly UserRepository _userRepository;

        public frmAdminPanel(User user)
        {
            InitializeComponent();
            _currentUser = user;
            _itemRepository = new ItemRepository();
            _claimRepository = new ClaimRepository();
            _userRepository = new UserRepository();
            LoadDashboardTab();
        }

        // load on changing tab
        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabMain.SelectedIndex)
            {
                case 0: LoadDashboardTab(); break;
                case 1: LoadLostItemsTab(); break;
                case 2: LoadFoundItemsTab(); break;
                case 3: LoadClaimsTab(); break;
                case 4: LoadUsersTab(); break;
            }
        }

        // Tab 1 — load Stats
        private void LoadDashboardTab()
        {
            try
            {
                lblTotalLost.Text = _itemRepository.GetLostItemCount().ToString();
                lblTotalFound.Text = _itemRepository.GetFoundItemCount().ToString();
                lblTotalClaimed.Text = _itemRepository.GetClaimedItemCount().ToString();
                lblPendingClaims.Text = _claimRepository.GetPendingClaimCount().ToString();
                lblRecovered.Text = _claimRepository.GetRecoveredItemCount().ToString();
                lblTotalUsers.Text = _userRepository.GetUserCount().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Tab 2 — Lost items
        private void LoadLostItemsTab()
        {
            try
            {
                var items = _itemRepository.GetLostItems();
                dgvLostItems.DataSource = null;
                dgvLostItems.DataSource = items;
                SetupGrid(dgvLostItems);
                ShowCol(dgvLostItems, "ItemID", "ID", 50);
                ShowCol(dgvLostItems, "ItemTitle", "Title", 200);
                ShowCol(dgvLostItems, "CategoryName", "Category", 120);
                ShowCol(dgvLostItems, "LocationName", "Location", 120);
                ShowCol(dgvLostItems, "ReportedByName", "Reported By", 130);
                ShowCol(dgvLostItems, "Status", "Status", 80);
                ShowCol(dgvLostItems, "DateOccurred", "Date", 100);

                if (dgvLostItems.Columns["DateOccurred"] != null)
                    dgvLostItems.Columns["DateOccurred"].DefaultCellStyle.Format = "dd-MMM-yyyy";

                //foreach (DataGridViewRow row in dgvLostItems.Rows)
                //    row.DefaultCellStyle.BackColor =
                //        Color.FromArgb(255, 226, 226);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Tab 3 — Found items
        private void LoadFoundItemsTab()
        {
            try
            {
                var items = _itemRepository.GetFoundItems();
                dgvFoundItems.DataSource = null;
                dgvFoundItems.DataSource = items;
                SetupGrid(dgvFoundItems);
                ShowCol(dgvFoundItems, "ItemID", "ID", 50);
                ShowCol(dgvFoundItems, "ItemTitle", "Title", 200);
                ShowCol(dgvFoundItems, "CategoryName", "Category", 120);
                ShowCol(dgvFoundItems, "LocationName", "Location", 120);
                ShowCol(dgvFoundItems, "ReportedByName", "Found By", 130);
                ShowCol(dgvFoundItems, "Status", "Status", 80);
                ShowCol(dgvFoundItems, "DateOccurred", "Date", 100);

                if (dgvFoundItems.Columns["DateOccurred"] != null)
                    dgvFoundItems.Columns["DateOccurred"].DefaultCellStyle.Format = "dd-MMM-yyyy";

                //foreach (DataGridViewRow row in dgvFoundItems.Rows)
                //    row.DefaultCellStyle.BackColor =
                //        Color.FromArgb(224, 242, 254);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Tab 4 — Claims
        private void LoadClaimsTab()
        {
            try
            {
                var claims = _claimRepository.GetPendingClaims();
                dgvClaims.DataSource = null;
                dgvClaims.DataSource = claims;
                SetupGrid(dgvClaims);
                ShowCol(dgvClaims, "ClaimID", "ID", 50);
                ShowCol(dgvClaims, "ItemTitle", "Item", 200);
                ShowCol(dgvClaims, "ClaimedByName", "Claimed By", 130);
                ShowCol(dgvClaims, "ClaimMessage", "Message", 250);
                ShowCol(dgvClaims, "Status", "Status", 80);
                ShowCol(dgvClaims, "ClaimDate", "Date", 100);

                if (dgvClaims.Columns["ClaimDate"] != null)
                    dgvClaims.Columns["ClaimDate"].DefaultCellStyle.Format = "dd-MMM-yyyy";

                foreach (DataGridViewRow row in dgvClaims.Rows)
                    row.DefaultCellStyle.BackColor =
                        Color.FromArgb(254, 249, 195);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Tab 5 — Users
        private void LoadUsersTab()
        {
            try
            {
                var users = _userRepository.GetAllUsers();
                dgvUsers.DataSource = null;
                dgvUsers.DataSource = users;
                SetupGrid(dgvUsers);
                ShowCol(dgvUsers, "UserID", "ID", 50);
                ShowCol(dgvUsers, "FullName", "Full Name", 150);
                ShowCol(dgvUsers, "Email", "Email", 200);
                ShowCol(dgvUsers, "Phone", "Phone", 120);
                ShowCol(dgvUsers, "Department", "Department", 120);
                ShowCol(dgvUsers, "Role", "Role", 80);
                ShowCol(dgvUsers, "RegistrationDate", "Registered", 110);

                if (dgvUsers.Columns["RegistrationDate"] != null)
                    dgvUsers.Columns["RegistrationDate"].DefaultCellStyle.Format = "dd-MMM-yyyy";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Claim Approve
        private void btnApproveClaim_Click(object sender, EventArgs e)
        {
            if (dgvClaims.CurrentRow == null)
            {
                MessageBox.Show("Please select a claim.");
                return;
            }

            var claim = dgvClaims.CurrentRow.DataBoundItem as Claim;
            if (claim == null) return;

            string note = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter admin note:", "Approve Claim",
                "Details verified");

            try
            {
                if (_claimRepository.ApproveClaim(claim.ClaimID, note))
                {
                    _itemRepository.UpdateItemStatus(claim.ItemID, "Claimed");
                    MessageBox.Show("Claim approved!", "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadClaimsTab();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Claim Reject
        private void btnRejectClaim_Click(object sender, EventArgs e)
        {
            if (dgvClaims.CurrentRow == null)
            {
                MessageBox.Show("Please select a claim.");
                return;
            }

            var claim = dgvClaims.CurrentRow.DataBoundItem as Claim;
            if (claim == null) return;

            string note = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter rejection reason:", "Reject Claim",
                "Details do not match");

            if (string.IsNullOrWhiteSpace(note)) return;

            try
            {
                if (_claimRepository.RejectClaim(claim.ClaimID, note))
                {
                    MessageBox.Show("Claim rejected.", "Done",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadClaimsTab();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Lost item delete
        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvLostItems.CurrentRow == null)
            {
                MessageBox.Show("Please select an item.");
                return;
            }

            var item = dgvLostItems.CurrentRow.DataBoundItem as Item;
            if (item == null) return;

            if (MessageBox.Show($"Delete '{item.ItemTitle}'?",
                "Confirm", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (_itemRepository.DeleteItem(item.ItemID))
                    {
                        MessageBox.Show("Item deleted.", "Success");
                        LoadLostItemsTab();
                    }
                    else
                        MessageBox.Show("Cannot delete — claims exist.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        // Found item delete
        private void btnDeleteFoundItem_Click(object sender, EventArgs e)
        {
            if (dgvFoundItems.CurrentRow == null)
            {
                MessageBox.Show("Please select an item.");
                return;
            }

            var item = dgvFoundItems.CurrentRow.DataBoundItem as Item;
            if (item == null) return;

            if (MessageBox.Show($"Delete '{item.ItemTitle}'?",
                "Confirm", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (_itemRepository.DeleteItem(item.ItemID))
                    {
                        MessageBox.Show("Item deleted.", "Success");
                        LoadFoundItemsTab();
                    }
                    else
                        MessageBox.Show("Cannot delete — claims exist.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        // User delete
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("Please select a user.");
                return;
            }

            var user = dgvUsers.CurrentRow.DataBoundItem as User;
            if (user == null) return;

            if (user.UserID == _currentUser.UserID)
            {
                MessageBox.Show("You cannot delete yourself!");
                return;
            }

            if (MessageBox.Show($"Delete '{user.FullName}'?",
                "Confirm", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (_userRepository.DeleteUser(user.UserID))
                    {
                        MessageBox.Show("User deleted.", "Success");
                        LoadUsersTab();
                    }
                    else
                        MessageBox.Show("Cannot delete — user has items.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        // Logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Logout?", "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new frmLogin().Show();
                this.Close();
            }
        }

        // Helper methods
        private void SetupGrid(DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            foreach (DataGridViewColumn col in dgv.Columns)
                col.Visible = false;
        }

        private void ShowCol(DataGridView dgv,
            string col, string header, int width)
        {
            if (dgv.Columns[col] != null)
            {
                dgv.Columns[col].Visible = true;
                dgv.Columns[col].HeaderText = header;
                dgv.Columns[col].Width = width;
            }
        }
    }
}