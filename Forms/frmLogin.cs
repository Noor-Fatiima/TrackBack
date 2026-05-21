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
    public partial class frmLogin : Form // Login form for user authentication
    {
        private readonly UserRepository _userRepository;

        public frmLogin()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter email.",
                    "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtEmail.Focus();
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

            try
            {
                // Authenticate user
                var user = _userRepository.Authenticate(txtEmail.Text.Trim(),txtPassword.Text);

                if (user != null)
                {
                    MessageBox.Show($"Welcome {user.FullName}! Role: {user.Role}", "Login Success");
                    if (user.Role == "Admin")
                    {
                        var adminForm = new frmAdminPanel(user);
                        adminForm.Show();
                    }
                    else
                    {
                        var dashboardForm = new frmUserDashboard(user);
                        dashboardForm.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password.",
                        "Login Failed", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPassword.Focus();
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
            Application.Exit();
        }


        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registerForm = new frmRegister();
            registerForm.ShowDialog();
        }


    }
}