using System;
using System.Windows.Forms;
using System.Data.SQLite;
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

        // for Edit mode 
        private Item _editItem = null;
        private bool _isEditMode = false;

        // ADD mode constructor — new item
        public frmAddItem(User user, string itemType)
        {
            InitializeComponent();
            _currentUser = user;
            _itemType = itemType;
            _itemRepository = new ItemRepository();
            _categoryRepository = new CategoryRepository();
            _locationRepository = new LocationRepository();
            _isEditMode = false;

            SetItemType();
            LoadDropdowns();
        }

        // EDIT mode constructor — old item
        public frmAddItem(User user, Item editItem)
        {
            InitializeComponent();
            _currentUser = user;
            _editItem = editItem;
            _itemType = editItem.ItemType;
            _itemRepository = new ItemRepository();
            _categoryRepository = new CategoryRepository();
            _locationRepository = new LocationRepository();
            _isEditMode = true;

            SetItemType();
            LoadDropdowns();
            FillEditData(); // Fill old data in the form
        }

        private void SetItemType()
        {
            if (_isEditMode)
            {
                this.Text = "Edit Item";
                lblTitle.Text = "Edit Item";
                btnSubmit.Text = "Update";
            }
            else if (_itemType == "Lost")
            {
                this.Text = "Report Lost Item";
                lblTitle.Text = "Report Lost Item";
                btnSubmit.Text = "Submit";
            }
            else
            {
                this.Text = "Register Found Item";
                lblTitle.Text = "Register Found Item";
                btnSubmit.Text = "Submit";
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
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Fill old data in the form for Edit mode
        private void FillEditData()
        {
            txtItemTitle.Text = _editItem.ItemTitle;
            txtDescription.Text = _editItem.Description;
            dtpDateOccurred.Value = _editItem.DateOccurred;

            // Set ItemType radio button
            if (_editItem.ItemType == "Lost")
                rbLost.Checked = true;
            else
                rbFound.Checked = true;

            // select right category and location in dropdowns
            cmbCategory.SelectedValue = _editItem.CategoryID;
            cmbLocation.SelectedValue = _editItem.LocationID;
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
                return;
            }

            if (cmbLocation.SelectedItem == null)
            {
                MessageBox.Show("Please select a location.",
                    "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_isEditMode)
                {
                    // EDIT MODE — update 
                    _editItem.CategoryID = (int)cmbCategory.SelectedValue;
                    _editItem.LocationID = (int)cmbLocation.SelectedValue;
                    _editItem.ItemTitle = txtItemTitle.Text.Trim();
                    _editItem.Description = txtDescription.Text.Trim();
                    _editItem.ItemType = rbLost.Checked ? "Lost" : "Found";
                    _editItem.DateOccurred = dtpDateOccurred.Value;

                    if (_itemRepository.UpdateItem(_editItem))
                    {
                        MessageBox.Show("Item updated successfully!",
                            "Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Update failed.",
                            "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // ADD MODE — add new item
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
                        MessageBox.Show("Failed to save item.",
                            "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}",
                    "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}