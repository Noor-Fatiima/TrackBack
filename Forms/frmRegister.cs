using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackBack.Forms;
using TrackBack.Database;
using TrackBack.Models;


namespace TrackBack.Forms
{
    public partial class frmRegister : Form
    {
        private readonly UserRepository _userRepository;
        public frmRegister()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Please enter full name.",
                    "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter email.",
                    "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please enter phone number.",
                    "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDepartment.Text))
            {
                MessageBox.Show("Please enter department.",
                    "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtDepartment.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter password.",
                    "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.",
                    "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.",
                    "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtConfirmPassword.Clear();
                txtConfirmPassword.Focus();
                return;
            }

            try
            {
                // Check email already exists
                if (_userRepository.EmailExists(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Email already registered.",
                        "Validation", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }

                // Create user object
                var user = new User
                {
                    FullName = txtFullName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Department = txtDepartment.Text.Trim(),
                    Role = "User"
                };

                // Add user — BCrypt hash will be automatically made 
                bool success = _userRepository.AddUser(user, txtPassword.Text);

                if (success)
                {
                    MessageBox.Show(
                        "Account created successfully!\nYou can now login.",
                        "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Registration failed. Try again.",
                        "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}",
                    "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void lnkBack_LinkClicked(object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            //txtFullName.Clear();
            //txtEmail.Clear();
            //txtPhone.Clear();
            //txtDepartment.Clear();
            //txtPassword.Clear();
            //txtConfirmPassword.Clear();
            //txtFullName.Focus();
        }
    }
}

