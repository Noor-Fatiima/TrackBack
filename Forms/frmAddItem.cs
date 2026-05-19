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
    public partial class frmAddItem : Form
    {
        private readonly User _currentUser;
        private readonly string _itemType;
        private readonly ItemRepository _itemRepository;
        private readonly CategoryRepository _categoryRepository;
        private readonly LocationRepository _locationRepository;

        public frmAddItem(User user, string itemType)
        {
            InitializeComponent();
            _currentUser = user;
            _itemType = itemType;
            _itemRepository = new ItemRepository();
            _categoryRepository = new CategoryRepository();
            _locationRepository = new LocationRepository();
            SetItemType();
            LoadDropdowns();
        }

        private void SetItemType()
        {
            if (_itemType == "Lost")
            {
                rbLost.Checked = true;
                lblTitle.Text = "Report Lost Item";
                this.Text = "Report Lost Item";
            }
            else
            {
                rbFound.Checked = true;
                lblTitle.Text = "Register Found Item";
                this.Text = "Register Found Item";
            }
        }

        private void LoadDropdowns()
        {
            try
            {
                var categories = _categoryRepository.GetAllCategories();
                cmbCategory.DataSource = categories;
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryID";

                var locations = _locationRepository.GetAllLocations();
                cmbLocation.DataSource = locations;
                cmbLocation.DisplayMember = "LocationName";
                cmbLocation.ValueMember = "LocationID";

                dtpDateOccurred.Value = DateTime.Today;
                dtpDateOccurred.MaxDate = DateTime.Today;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtItemTitle.Text))
            {
                MessageBox.Show("Please enter item title.",
                    "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtItemTitle.Focus();
                return;
            }

            if (cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.",
                    "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                cmbCategory.Focus();
                return;
            }

            if (cmbLocation.SelectedItem == null)
            {
                MessageBox.Show("Please select a location.",
                    "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                cmbLocation.Focus();
                return;
            }

            try
            {
                var item = new Item
                {
                    UserID = _currentUser.UserID,
                    CategoryID = (int)cmbCategory.SelectedValue,
                    LocationID = (int)cmbLocation.SelectedValue,
                    ItemTitle = txtItemTitle.Text.Trim(),
                    Description = txtDescription.Text.Trim(),
                    ItemType = rbLost.Checked ? "Lost" : "Found",
                    DateOccurred = dtpDateOccurred.Value,
                    Status = "Active",
                    //IsMatched = false
                };

                if (_itemRepository.AddItem(item))
                {
                        MessageBox.Show("Item reported successfully!",
                            "Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to save item.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}