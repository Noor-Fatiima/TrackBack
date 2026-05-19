namespace TrackBack.Forms
{
    partial class frmAdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnLogout = new Button();
            lblAdminName = new Label();
            lblTitle = new Label();
            tabMain = new TabControl();
            tabDashboard = new TabPage();
            panel3 = new Panel();
            lblTotalUsers = new Label();
            label5 = new Label();
            panel2 = new Panel();
            lblRecovered = new Label();
            label2 = new Label();
            pnlStatPending = new Panel();
            lblPendingClaims = new Label();
            label9 = new Label();
            pnlStatFound = new Panel();
            lblTotalFound = new Label();
            label7 = new Label();
            pnlStatClaimed = new Panel();
            lblTotalClaimed = new Label();
            label12 = new Label();
            pnlStatLost = new Panel();
            lblTotalLost = new Label();
            label4 = new Label();
            tabLostItems = new TabPage();
            btnDeleteItem = new Button();
            dgvLostItems = new DataGridView();
            tabFoundItems = new TabPage();
            btnDeleteFoundItem = new Button();
            dgvFoundItems = new DataGridView();
            tabClaims = new TabPage();
            btnApproveClaim = new Button();
            btnRejectClaim = new Button();
            dgvClaims = new DataGridView();
            tabUsers = new TabPage();
            btnDeleteUser = new Button();
            dgvUsers = new DataGridView();
            panel1.SuspendLayout();
            tabMain.SuspendLayout();
            tabDashboard.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            pnlStatPending.SuspendLayout();
            pnlStatFound.SuspendLayout();
            pnlStatClaimed.SuspendLayout();
            pnlStatLost.SuspendLayout();
            tabLostItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLostItems).BeginInit();
            tabFoundItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFoundItems).BeginInit();
            tabClaims.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClaims).BeginInit();
            tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(lblAdminName);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1768, 217);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(220, 38, 38);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(1412, 40);
            btnLogout.Margin = new Padding(5);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(209, 108);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblAdminName
            // 
            lblAdminName.AutoSize = true;
            lblAdminName.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblAdminName.ForeColor = Color.White;
            lblAdminName.Location = new Point(727, 114);
            lblAdminName.Margin = new Padding(4, 0, 4, 0);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Size = new Size(330, 51);
            lblAdminName.TabIndex = 1;
            lblAdminName.Text = "Welcome Admin!";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(762, 40);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(249, 51);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Admin Panel";
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabDashboard);
            tabMain.Controls.Add(tabLostItems);
            tabMain.Controls.Add(tabFoundItems);
            tabMain.Controls.Add(tabClaims);
            tabMain.Controls.Add(tabUsers);
            tabMain.Location = new Point(390, 336);
            tabMain.Margin = new Padding(4);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(912, 570);
            tabMain.TabIndex = 1;
            tabMain.SelectedIndexChanged += tabMain_SelectedIndexChanged;
            tabMain.Click += btnDeleteFoundItem_Click;
            // 
            // tabDashboard
            // 
            tabDashboard.Controls.Add(panel3);
            tabDashboard.Controls.Add(panel2);
            tabDashboard.Controls.Add(pnlStatPending);
            tabDashboard.Controls.Add(pnlStatFound);
            tabDashboard.Controls.Add(pnlStatClaimed);
            tabDashboard.Controls.Add(pnlStatLost);
            tabDashboard.Location = new Point(4, 39);
            tabDashboard.Margin = new Padding(4);
            tabDashboard.Name = "tabDashboard";
            tabDashboard.Padding = new Padding(4);
            tabDashboard.Size = new Size(904, 527);
            tabDashboard.TabIndex = 0;
            tabDashboard.Text = "Dashboard";
            tabDashboard.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightBlue;
            panel3.Controls.Add(lblTotalUsers);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(508, 347);
            panel3.Name = "panel3";
            panel3.Size = new Size(303, 106);
            panel3.TabIndex = 13;
            // 
            // lblTotalUsers
            // 
            lblTotalUsers.AutoSize = true;
            lblTotalUsers.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotalUsers.ForeColor = Color.Black;
            lblTotalUsers.Location = new Point(237, 39);
            lblTotalUsers.Name = "lblTotalUsers";
            lblTotalUsers.Size = new Size(26, 30);
            lblTotalUsers.TabIndex = 1;
            lblTotalUsers.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(35, 38);
            label5.Name = "label5";
            label5.Size = new Size(76, 30);
            label5.TabIndex = 0;
            label5.Text = "Users:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightBlue;
            panel2.Controls.Add(lblRecovered);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(73, 347);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 106);
            panel2.TabIndex = 12;
            // 
            // lblRecovered
            // 
            lblRecovered.AutoSize = true;
            lblRecovered.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblRecovered.ForeColor = Color.Black;
            lblRecovered.Location = new Point(218, 39);
            lblRecovered.Name = "lblRecovered";
            lblRecovered.Size = new Size(26, 30);
            lblRecovered.TabIndex = 1;
            lblRecovered.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(35, 38);
            label2.Name = "label2";
            label2.Size = new Size(127, 30);
            label2.TabIndex = 0;
            label2.Text = "Recovered:";
            // 
            // pnlStatPending
            // 
            pnlStatPending.BackColor = Color.LightBlue;
            pnlStatPending.Controls.Add(lblPendingClaims);
            pnlStatPending.Controls.Add(label9);
            pnlStatPending.Location = new Point(508, 188);
            pnlStatPending.Name = "pnlStatPending";
            pnlStatPending.Size = new Size(303, 106);
            pnlStatPending.TabIndex = 9;
            // 
            // lblPendingClaims
            // 
            lblPendingClaims.AutoSize = true;
            lblPendingClaims.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPendingClaims.ForeColor = Color.Black;
            lblPendingClaims.Location = new Point(238, 39);
            lblPendingClaims.Name = "lblPendingClaims";
            lblPendingClaims.Size = new Size(26, 30);
            lblPendingClaims.TabIndex = 1;
            lblPendingClaims.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(35, 39);
            label9.Name = "label9";
            label9.Size = new Size(104, 30);
            label9.TabIndex = 0;
            label9.Text = "Pending:";
            // 
            // pnlStatFound
            // 
            pnlStatFound.BackColor = Color.LightBlue;
            pnlStatFound.Controls.Add(lblTotalFound);
            pnlStatFound.Controls.Add(label7);
            pnlStatFound.Location = new Point(508, 37);
            pnlStatFound.Name = "pnlStatFound";
            pnlStatFound.Size = new Size(303, 106);
            pnlStatFound.TabIndex = 11;
            // 
            // lblTotalFound
            // 
            lblTotalFound.AutoSize = true;
            lblTotalFound.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotalFound.ForeColor = Color.Black;
            lblTotalFound.Location = new Point(238, 39);
            lblTotalFound.Name = "lblTotalFound";
            lblTotalFound.Size = new Size(26, 30);
            lblTotalFound.TabIndex = 1;
            lblTotalFound.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(27, 39);
            label7.Name = "label7";
            label7.Size = new Size(140, 30);
            label7.TabIndex = 0;
            label7.Text = "Total Found:";
            // 
            // pnlStatClaimed
            // 
            pnlStatClaimed.BackColor = Color.LightBlue;
            pnlStatClaimed.Controls.Add(lblTotalClaimed);
            pnlStatClaimed.Controls.Add(label12);
            pnlStatClaimed.Location = new Point(73, 188);
            pnlStatClaimed.Name = "pnlStatClaimed";
            pnlStatClaimed.Size = new Size(290, 106);
            pnlStatClaimed.TabIndex = 10;
            // 
            // lblTotalClaimed
            // 
            lblTotalClaimed.AutoSize = true;
            lblTotalClaimed.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotalClaimed.ForeColor = Color.Black;
            lblTotalClaimed.Location = new Point(218, 39);
            lblTotalClaimed.Name = "lblTotalClaimed";
            lblTotalClaimed.Size = new Size(26, 30);
            lblTotalClaimed.TabIndex = 1;
            lblTotalClaimed.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(35, 38);
            label12.Name = "label12";
            label12.Size = new Size(103, 30);
            label12.TabIndex = 0;
            label12.Text = "Claimed:";
            // 
            // pnlStatLost
            // 
            pnlStatLost.BackColor = Color.LightBlue;
            pnlStatLost.Controls.Add(lblTotalLost);
            pnlStatLost.Controls.Add(label4);
            pnlStatLost.Location = new Point(73, 37);
            pnlStatLost.Name = "pnlStatLost";
            pnlStatLost.Size = new Size(290, 106);
            pnlStatLost.TabIndex = 8;
            // 
            // lblTotalLost
            // 
            lblTotalLost.AutoSize = true;
            lblTotalLost.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotalLost.ForeColor = Color.Black;
            lblTotalLost.Location = new Point(218, 39);
            lblTotalLost.Name = "lblTotalLost";
            lblTotalLost.Size = new Size(26, 30);
            lblTotalLost.TabIndex = 1;
            lblTotalLost.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(35, 38);
            label4.Name = "label4";
            label4.Size = new Size(119, 30);
            label4.TabIndex = 0;
            label4.Text = "Total Lost:";
            // 
            // tabLostItems
            // 
            tabLostItems.Controls.Add(btnDeleteItem);
            tabLostItems.Controls.Add(dgvLostItems);
            tabLostItems.Location = new Point(4, 39);
            tabLostItems.Margin = new Padding(4);
            tabLostItems.Name = "tabLostItems";
            tabLostItems.Padding = new Padding(4);
            tabLostItems.Size = new Size(904, 527);
            tabLostItems.TabIndex = 1;
            tabLostItems.Text = "Lost Items";
            tabLostItems.UseVisualStyleBackColor = true;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.BackColor = Color.FromArgb(220, 38, 38);
            btnDeleteItem.FlatStyle = FlatStyle.Flat;
            btnDeleteItem.ForeColor = Color.White;
            btnDeleteItem.Location = new Point(289, 340);
            btnDeleteItem.Margin = new Padding(5);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(238, 108);
            btnDeleteItem.TabIndex = 6;
            btnDeleteItem.Text = "Delete Item";
            btnDeleteItem.UseVisualStyleBackColor = false;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // dgvLostItems
            // 
            dgvLostItems.AllowUserToAddRows = false;
            dgvLostItems.AllowUserToDeleteRows = false;
            dgvLostItems.BackgroundColor = Color.White;
            dgvLostItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLostItems.Location = new Point(27, 34);
            dgvLostItems.Name = "dgvLostItems";
            dgvLostItems.ReadOnly = true;
            dgvLostItems.RowHeadersWidth = 62;
            dgvLostItems.Size = new Size(828, 252);
            dgvLostItems.TabIndex = 3;
            // 
            // tabFoundItems
            // 
            tabFoundItems.Controls.Add(btnDeleteFoundItem);
            tabFoundItems.Controls.Add(dgvFoundItems);
            tabFoundItems.Location = new Point(4, 39);
            tabFoundItems.Margin = new Padding(4);
            tabFoundItems.Name = "tabFoundItems";
            tabFoundItems.Padding = new Padding(4);
            tabFoundItems.Size = new Size(904, 527);
            tabFoundItems.TabIndex = 2;
            tabFoundItems.Text = "Found Items";
            tabFoundItems.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFoundItem
            // 
            btnDeleteFoundItem.BackColor = Color.FromArgb(220, 38, 38);
            btnDeleteFoundItem.FlatStyle = FlatStyle.Flat;
            btnDeleteFoundItem.ForeColor = Color.White;
            btnDeleteFoundItem.Location = new Point(300, 362);
            btnDeleteFoundItem.Margin = new Padding(5);
            btnDeleteFoundItem.Name = "btnDeleteFoundItem";
            btnDeleteFoundItem.Size = new Size(238, 108);
            btnDeleteFoundItem.TabIndex = 8;
            btnDeleteFoundItem.Text = "Delete Item";
            btnDeleteFoundItem.UseVisualStyleBackColor = false;
            // 
            // dgvFoundItems
            // 
            dgvFoundItems.AllowUserToAddRows = false;
            dgvFoundItems.AllowUserToDeleteRows = false;
            dgvFoundItems.BackgroundColor = Color.White;
            dgvFoundItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoundItems.Location = new Point(38, 56);
            dgvFoundItems.Name = "dgvFoundItems";
            dgvFoundItems.ReadOnly = true;
            dgvFoundItems.RowHeadersWidth = 62;
            dgvFoundItems.Size = new Size(828, 252);
            dgvFoundItems.TabIndex = 7;
            // 
            // tabClaims
            // 
            tabClaims.Controls.Add(btnApproveClaim);
            tabClaims.Controls.Add(btnRejectClaim);
            tabClaims.Controls.Add(dgvClaims);
            tabClaims.Location = new Point(4, 39);
            tabClaims.Margin = new Padding(4);
            tabClaims.Name = "tabClaims";
            tabClaims.Size = new Size(904, 527);
            tabClaims.TabIndex = 3;
            tabClaims.Text = "Claims";
            tabClaims.UseVisualStyleBackColor = true;
            // 
            // btnApproveClaim
            // 
            btnApproveClaim.BackColor = Color.SteelBlue;
            btnApproveClaim.FlatStyle = FlatStyle.Flat;
            btnApproveClaim.ForeColor = Color.White;
            btnApproveClaim.Location = new Point(168, 358);
            btnApproveClaim.Margin = new Padding(5);
            btnApproveClaim.Name = "btnApproveClaim";
            btnApproveClaim.Size = new Size(238, 108);
            btnApproveClaim.TabIndex = 9;
            btnApproveClaim.Text = "Approve";
            btnApproveClaim.UseVisualStyleBackColor = false;
            btnApproveClaim.Click += btnApproveClaim_Click;
            // 
            // btnRejectClaim
            // 
            btnRejectClaim.BackColor = Color.FromArgb(220, 38, 38);
            btnRejectClaim.FlatStyle = FlatStyle.Flat;
            btnRejectClaim.ForeColor = Color.White;
            btnRejectClaim.Location = new Point(496, 358);
            btnRejectClaim.Margin = new Padding(5);
            btnRejectClaim.Name = "btnRejectClaim";
            btnRejectClaim.Size = new Size(238, 108);
            btnRejectClaim.TabIndex = 8;
            btnRejectClaim.Text = "Reject";
            btnRejectClaim.UseVisualStyleBackColor = false;
            btnRejectClaim.Click += btnRejectClaim_Click;
            // 
            // dgvClaims
            // 
            dgvClaims.AllowUserToAddRows = false;
            dgvClaims.AllowUserToDeleteRows = false;
            dgvClaims.BackgroundColor = Color.White;
            dgvClaims.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClaims.Location = new Point(38, 56);
            dgvClaims.Name = "dgvClaims";
            dgvClaims.ReadOnly = true;
            dgvClaims.RowHeadersWidth = 62;
            dgvClaims.Size = new Size(828, 252);
            dgvClaims.TabIndex = 7;
            // 
            // tabUsers
            // 
            tabUsers.Controls.Add(btnDeleteUser);
            tabUsers.Controls.Add(dgvUsers);
            tabUsers.Location = new Point(4, 39);
            tabUsers.Margin = new Padding(4);
            tabUsers.Name = "tabUsers";
            tabUsers.Size = new Size(904, 527);
            tabUsers.TabIndex = 4;
            tabUsers.Text = "Users";
            tabUsers.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.FromArgb(220, 38, 38);
            btnDeleteUser.FlatStyle = FlatStyle.Flat;
            btnDeleteUser.ForeColor = Color.White;
            btnDeleteUser.Location = new Point(300, 362);
            btnDeleteUser.Margin = new Padding(5);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(238, 108);
            btnDeleteUser.TabIndex = 8;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(38, 56);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersWidth = 62;
            dgvUsers.Size = new Size(828, 252);
            dgvUsers.TabIndex = 7;
            // 
            // frmAdminPanel
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1768, 878);
            Controls.Add(tabMain);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "frmAdminPanel";
            Text = "Admin Panel";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabMain.ResumeLayout(false);
            tabDashboard.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlStatPending.ResumeLayout(false);
            pnlStatPending.PerformLayout();
            pnlStatFound.ResumeLayout(false);
            pnlStatFound.PerformLayout();
            pnlStatClaimed.ResumeLayout(false);
            pnlStatClaimed.PerformLayout();
            pnlStatLost.ResumeLayout(false);
            pnlStatLost.PerformLayout();
            tabLostItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLostItems).EndInit();
            tabFoundItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFoundItems).EndInit();
            tabClaims.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClaims).EndInit();
            tabUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private TabControl tabMain;
        private TabPage tabDashboard;
        private TabPage tabLostItems;
        private Label lblAdminName;
        private TabPage tabFoundItems;
        private TabPage tabClaims;
        private TabPage tabUsers;
        private Button btnLogout;
        private Panel panel2;
        private Label lblRecovered;
        private Label label2;
        private Panel pnlStatPending;
        private Label lblPendingClaims;
        private Label label9;
        private Panel pnlStatFound;
        private Label lblTotalFound;
        private Label label7;
        private Panel pnlStatClaimed;
        private Label lblTotalClaimed;
        private Label label12;
        private Panel pnlStatLost;
        private Label lblTotalLost;
        private Label label4;
        private Panel panel3;
        private Label lblTotalUsers;
        private Label label5;
        private Button btnDeleteItem;
        private DataGridView dgvLostItems;
        private Button btnDeleteFoundItem;
        private DataGridView dgvFoundItems;
        private Button btnApproveClaim;
        private Button btnRejectClaim;
        private DataGridView dgvClaims;
        private Button btnDeleteUser;
        private DataGridView dgvUsers;
    }
}