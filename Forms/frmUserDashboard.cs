using System;
using System.Drawing;
using System.Windows.Forms;
using TrackBack.Database;
using TrackBack.Models;

namespace TrackBack.Forms
{
    public partial class frmUserDashboard : Form
    {
        private readonly User _currentUser;
        private readonly ItemRepository _itemRepository;
        private readonly ClaimRepository _claimRepository;

        public frmUserDashboard(User user)
        {
            InitializeComponent();
            _currentUser = user;
            _itemRepository = new ItemRepository();
            _claimRepository = new ClaimRepository();
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            lblUserName.Text = $"Welcome, {_currentUser.FullName}";
            lblUserRole.Text = $"Role: {_currentUser.Role}";

            try
            {
                var myItems = _itemRepository.GetItemsByUserID(_currentUser.UserID);
                var myClaims = _claimRepository.GetClaimsByUserID(_currentUser.UserID);

                lblLostCount.Text = myItems.FindAll(i => i.ItemType == "Lost").Count.ToString();
                lblFoundCount.Text = myItems.FindAll(i => i.ItemType == "Found").Count.ToString();
                lblClaimsCount.Text = myClaims.Count.ToString();
                lblPendingCount.Text = myClaims.FindAll(c => c.Status == "Pending").Count.ToString();

                // Recent items grid
                dgvRecentItems.DataSource = null; 
                dgvRecentItems.DataSource = myItems;
                dgvRecentItems.AllowUserToAddRows = false;
                dgvRecentItems.ReadOnly = true;
                dgvRecentItems.RowHeadersVisible = false;

                foreach (DataGridViewColumn col in dgvRecentItems.Columns)
                    col.Visible = false; //first hide all then show those only which are needed

                ShowCol(dgvRecentItems, "ItemTitle", "Item", 200);
                ShowCol(dgvRecentItems, "ItemType", "Type", 70);
                ShowCol(dgvRecentItems, "CategoryName", "Category", 120);
                ShowCol(dgvRecentItems, "LocationName", "Location", 120);
                ShowCol(dgvRecentItems, "Status", "Status", 80);
                ShowCol(dgvRecentItems, "DateReported", "Date", 110);

                if (dgvRecentItems.Columns["DateReported"] != null)
                    dgvRecentItems.Columns["DateReported"].DefaultCellStyle.Format = "dd-MMM-yyyy";


                // Claims grid
                dgvMyClaims.DataSource = null;
                dgvMyClaims.DataSource = myClaims;
                dgvMyClaims.AllowUserToAddRows = false;
                dgvMyClaims.ReadOnly = true;
                dgvMyClaims.RowHeadersVisible = false;

                foreach (DataGridViewColumn col in dgvMyClaims.Columns)
                    col.Visible = false;

                ShowCol(dgvMyClaims, "ItemTitle", "Item", 200);
                ShowCol(dgvMyClaims, "Status", "Status", 100);
                ShowCol(dgvMyClaims, "ClaimDate", "Claim Date", 110);
                ShowCol(dgvMyClaims, "AdminNote", "Admin Note", 200);

                if (dgvMyClaims.Columns["ClaimDate"] != null)
                    dgvMyClaims.Columns["ClaimDate"].DefaultCellStyle.Format = "dd-MMM-yyyy";

            }
            catch (Exception ex)  // on any error this message box will show
            {
                MessageBox.Show($"Error: {ex.Message}",
                    "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        //Helper Method has 4 parameters - dgv = which grid(RecentItems or MyClaims), col = actual name of column(property name),
                                         //header = heading that will show,           width = width in pixels
        private void ShowCol(DataGridView dgv, string col, string header, int width)
        {
            if (dgv.Columns[col] != null) //column exists?
            {
                dgv.Columns[col].Visible = true;
                dgv.Columns[col].HeaderText = header;
                dgv.Columns[col].Width = width;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void btnReportLost_Click(object sender, EventArgs e)
        {
            var form = new frmAddItem(_currentUser, "Lost");
            form.ShowDialog();
            LoadDashboard(); //refreshes dahboard - new item will show which user reported
        }

        private void btnRegisterFound_Click(object sender, EventArgs e)
        {
            var form = new frmAddItem(_currentUser, "Found");
            form.ShowDialog();
            LoadDashboard();
        }

        private void btnSearchItems_Click(object sender, EventArgs e)
        {
            new frmSearchItems(_currentUser).Show();
        }

        private void btnMyClaims_Click(object sender, EventArgs e)
        {
            // on claims grid
            dgvMyClaims.Focus();
            dgvMyClaims.BringToFront();

            // Refresh claims
            var myClaims = _claimRepository.GetClaimsByUserID(_currentUser.UserID);

            dgvMyClaims.DataSource = null;
            dgvMyClaims.DataSource = myClaims;

            MessageBox.Show(
                $"You have {myClaims.Count} claim(s).\n" +
                "Check the My Claims section below.",
                "My Claims", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?",
                "Confirm Logout", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                new frmLogin().Show();
                this.Close();
            }
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            // is any row selected?
            if (dgvRecentItems.CurrentRow == null)
            {
                MessageBox.Show("Please select an item to edit.",
                    "No Selection", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            //DataBoundItem - Actual object behind Selected Row ... then cast object to Item
            var selectedItem = dgvRecentItems.CurrentRow.DataBoundItem as Item;

            if (selectedItem == null) return;

            // only active items can be edited
            if (selectedItem.Status != "Active")
            {
                MessageBox.Show(
                    "Only Active items can be edited.\n" +
                    "Claimed or Closed items cannot be changed.",
                    "Cannot Edit", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // open frmAddItem in edit mode
            var editForm = new frmAddItem(_currentUser, selectedItem);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadDashboard(); // refresh data
            }
        }
    }
}
