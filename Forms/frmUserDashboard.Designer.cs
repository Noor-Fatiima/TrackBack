namespace TrackBack.Forms
{
    partial class frmUserDashboard
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
            btnMyClaims = new Button();
            btnSearchItems = new Button();
            btnRegisterFound = new Button();
            btnReportLost = new Button();
            btnDashboard = new Button();
            lblUserRole = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            pnlLost = new Panel();
            lblLostCount = new Label();
            label4 = new Label();
            panel3 = new Panel();
            lblClaimsCount = new Label();
            label12 = new Label();
            panel4 = new Panel();
            lblFoundCount = new Label();
            label7 = new Label();
            panel5 = new Panel();
            lblPendingCount = new Label();
            label9 = new Label();
            lblRecentActivity = new Label();
            dgvRecentItems = new DataGridView();
            dgvMyClaims = new DataGridView();
            lblClaimsTitle = new Label();
            lblUserName = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlLost.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMyClaims).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(lblUserName);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnMyClaims);
            panel1.Controls.Add(btnSearchItems);
            panel1.Controls.Add(btnRegisterFound);
            panel1.Controls.Add(btnReportLost);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(lblUserRole);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 1094);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(220, 38, 38);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(484, 706);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(191, 95);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnMyClaims
            // 
            btnMyClaims.FlatStyle = FlatStyle.Flat;
            btnMyClaims.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnMyClaims.ForeColor = Color.White;
            btnMyClaims.Location = new Point(122, 706);
            btnMyClaims.Name = "btnMyClaims";
            btnMyClaims.Size = new Size(191, 95);
            btnMyClaims.TabIndex = 7;
            btnMyClaims.Text = "My Claims";
            btnMyClaims.UseVisualStyleBackColor = true;
            btnMyClaims.Click += btnMyClaims_Click;
            // 
            // btnSearchItems
            // 
            btnSearchItems.FlatStyle = FlatStyle.Flat;
            btnSearchItems.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSearchItems.ForeColor = Color.White;
            btnSearchItems.Location = new Point(484, 504);
            btnSearchItems.Name = "btnSearchItems";
            btnSearchItems.Size = new Size(191, 95);
            btnSearchItems.TabIndex = 6;
            btnSearchItems.Text = "Search Items";
            btnSearchItems.UseVisualStyleBackColor = true;
            btnSearchItems.Click += btnSearchItems_Click;
            // 
            // btnRegisterFound
            // 
            btnRegisterFound.FlatStyle = FlatStyle.Flat;
            btnRegisterFound.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegisterFound.ForeColor = Color.White;
            btnRegisterFound.Location = new Point(122, 504);
            btnRegisterFound.Name = "btnRegisterFound";
            btnRegisterFound.Size = new Size(191, 95);
            btnRegisterFound.TabIndex = 5;
            btnRegisterFound.Text = "Register Found \r\n  Items";
            btnRegisterFound.UseVisualStyleBackColor = true;
            btnRegisterFound.Click += btnRegisterFound_Click;
            // 
            // btnReportLost
            // 
            btnReportLost.FlatStyle = FlatStyle.Flat;
            btnReportLost.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnReportLost.ForeColor = Color.White;
            btnReportLost.Location = new Point(484, 312);
            btnReportLost.Name = "btnReportLost";
            btnReportLost.Size = new Size(191, 95);
            btnReportLost.TabIndex = 4;
            btnReportLost.Text = "Report Lost   Items";
            btnReportLost.UseVisualStyleBackColor = true;
            btnReportLost.Click += btnReportLost_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(122, 303);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(191, 95);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblUserRole
            // 
            lblUserRole.AutoSize = true;
            lblUserRole.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblUserRole.ForeColor = Color.White;
            lblUserRole.Location = new Point(256, 218);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(223, 54);
            lblUserRole.TabIndex = 1;
            lblUserRole.Text = " Role: User\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(268, 61);
            label1.Name = "label1";
            label1.Size = new Size(211, 54);
            label1.TabIndex = 0;
            label1.Text = "TrackBack";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(786, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(961, 157);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(30, 41, 59);
            label2.Location = new Point(352, 42);
            label2.Name = "label2";
            label2.Size = new Size(216, 51);
            label2.TabIndex = 0;
            label2.Text = "Dashboard";
            // 
            // pnlLost
            // 
            pnlLost.BackColor = Color.LightBlue;
            pnlLost.Controls.Add(lblLostCount);
            pnlLost.Controls.Add(label4);
            pnlLost.Location = new Point(871, 218);
            pnlLost.Name = "pnlLost";
            pnlLost.Size = new Size(290, 106);
            pnlLost.TabIndex = 2;
            // 
            // lblLostCount
            // 
            lblLostCount.AutoSize = true;
            lblLostCount.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblLostCount.ForeColor = Color.Black;
            lblLostCount.Location = new Point(218, 39);
            lblLostCount.Name = "lblLostCount";
            lblLostCount.Size = new Size(26, 30);
            lblLostCount.TabIndex = 1;
            lblLostCount.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(35, 38);
            label4.Name = "label4";
            label4.Size = new Size(165, 30);
            label4.TabIndex = 0;
            label4.Text = "My Lost Items:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightBlue;
            panel3.Controls.Add(lblClaimsCount);
            panel3.Controls.Add(label12);
            panel3.Location = new Point(871, 396);
            panel3.Name = "panel3";
            panel3.Size = new Size(290, 106);
            panel3.TabIndex = 6;
            // 
            // lblClaimsCount
            // 
            lblClaimsCount.AutoSize = true;
            lblClaimsCount.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblClaimsCount.ForeColor = Color.Black;
            lblClaimsCount.Location = new Point(218, 39);
            lblClaimsCount.Name = "lblClaimsCount";
            lblClaimsCount.Size = new Size(26, 30);
            lblClaimsCount.TabIndex = 1;
            lblClaimsCount.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(35, 38);
            label12.Name = "label12";
            label12.Size = new Size(126, 30);
            label12.TabIndex = 0;
            label12.Text = "My Claims:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightBlue;
            panel4.Controls.Add(lblFoundCount);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(1355, 218);
            panel4.Name = "panel4";
            panel4.Size = new Size(303, 106);
            panel4.TabIndex = 7;
            // 
            // lblFoundCount
            // 
            lblFoundCount.AutoSize = true;
            lblFoundCount.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFoundCount.ForeColor = Color.Black;
            lblFoundCount.Location = new Point(238, 39);
            lblFoundCount.Name = "lblFoundCount";
            lblFoundCount.Size = new Size(26, 30);
            lblFoundCount.TabIndex = 1;
            lblFoundCount.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(27, 39);
            label7.Name = "label7";
            label7.Size = new Size(186, 30);
            label7.TabIndex = 0;
            label7.Text = "My Found Items:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightBlue;
            panel5.Controls.Add(lblPendingCount);
            panel5.Controls.Add(label9);
            panel5.Location = new Point(1355, 396);
            panel5.Name = "panel5";
            panel5.Size = new Size(303, 106);
            panel5.TabIndex = 3;
            // 
            // lblPendingCount
            // 
            lblPendingCount.AutoSize = true;
            lblPendingCount.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPendingCount.ForeColor = Color.Black;
            lblPendingCount.Location = new Point(238, 39);
            lblPendingCount.Name = "lblPendingCount";
            lblPendingCount.Size = new Size(26, 30);
            lblPendingCount.TabIndex = 1;
            lblPendingCount.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(35, 39);
            label9.Name = "label9";
            label9.Size = new Size(178, 30);
            label9.TabIndex = 0;
            label9.Text = "Pending Claims:";
            // 
            // lblRecentActivity
            // 
            lblRecentActivity.AutoSize = true;
            lblRecentActivity.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblRecentActivity.ForeColor = Color.SteelBlue;
            lblRecentActivity.Location = new Point(818, 561);
            lblRecentActivity.Name = "lblRecentActivity";
            lblRecentActivity.Size = new Size(214, 38);
            lblRecentActivity.TabIndex = 8;
            lblRecentActivity.Text = "Recent Activity";
            // 
            // dgvRecentItems
            // 
            dgvRecentItems.AllowUserToAddRows = false;
            dgvRecentItems.AllowUserToDeleteRows = false;
            dgvRecentItems.BackgroundColor = SystemColors.ButtonHighlight;
            dgvRecentItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentItems.Location = new Point(806, 621);
            dgvRecentItems.Name = "dgvRecentItems";
            dgvRecentItems.ReadOnly = true;
            dgvRecentItems.RowHeadersWidth = 62;
            dgvRecentItems.Size = new Size(903, 167);
            dgvRecentItems.TabIndex = 9;
            // 
            // dgvMyClaims
            // 
            dgvMyClaims.AllowUserToAddRows = false;
            dgvMyClaims.AllowUserToDeleteRows = false;
            dgvMyClaims.BackgroundColor = SystemColors.ButtonHighlight;
            dgvMyClaims.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyClaims.Location = new Point(806, 889);
            dgvMyClaims.Name = "dgvMyClaims";
            dgvMyClaims.ReadOnly = true;
            dgvMyClaims.RowHeadersWidth = 62;
            dgvMyClaims.Size = new Size(903, 167);
            dgvMyClaims.TabIndex = 11;
            // 
            // lblClaimsTitle
            // 
            lblClaimsTitle.AutoSize = true;
            lblClaimsTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblClaimsTitle.ForeColor = Color.SteelBlue;
            lblClaimsTitle.Location = new Point(818, 829);
            lblClaimsTitle.Name = "lblClaimsTitle";
            lblClaimsTitle.Size = new Size(153, 38);
            lblClaimsTitle.TabIndex = 12;
            lblClaimsTitle.Text = "My Claims";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblUserName.ForeColor = Color.White;
            lblUserName.Location = new Point(223, 139);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(293, 54);
            lblUserName.TabIndex = 9;
            lblUserName.Text = "Welcome User\r\n";
            // 
            // frmUserDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1747, 1094);
            Controls.Add(lblClaimsTitle);
            Controls.Add(dgvMyClaims);
            Controls.Add(dgvRecentItems);
            Controls.Add(lblRecentActivity);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(pnlLost);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmUserDashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlLost.ResumeLayout(false);
            pnlLost.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMyClaims).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblUserRole;
        private Label label1;
        private Button btnDashboard;
        private Button btnLogout;
        private Button btnMyClaims;
        private Button btnSearchItems;
        private Button btnRegisterFound;
        private Button btnReportLost;
        private Panel panel2;
        private Label label2;
        private Panel pnlLost;
        private Label lblLostCount;
        private Label label4;
        private Panel panel3;
        private Label lblClaimsCount;
        private Label label12;
        private Panel panel4;
        private Label lblFoundCount;
        private Label label7;
        private Panel panel5;
        private Label lblPendingCount;
        private Label label9;
        private Label lblRecentActivity;
        private DataGridView dgvRecentItems;
        private DataGridView dgvMyClaims;
        private Label lblClaimsTitle;
        private Label lblUserName;
    }
}