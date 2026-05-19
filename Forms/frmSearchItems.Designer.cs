namespace TrackBack.Forms
{
    partial class frmSearchItems
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
            label1 = new Label();
            panel2 = new Panel();
            btnClear = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dgvItems = new DataGridView();
            panel3 = new Panel();
            lblStatus = new Label();
            btnClose = new Button();
            btnClaim = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1684, 179);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(611, 56);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(329, 67);
            label1.TabIndex = 0;
            label1.Text = "Search Items";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(txtSearch);
            panel2.Location = new Point(13, 206);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(810, 397);
            panel2.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(220, 38, 38);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(452, 207);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(236, 90);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.SteelBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(54, 207);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(236, 90);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(132, 65);
            txtSearch.Margin = new Padding(4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(532, 37);
            txtSearch.TabIndex = 1;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.BackgroundColor = Color.White;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(844, 282);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersWidth = 62;
            dgvItems.Size = new Size(828, 252);
            dgvItems.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Controls.Add(lblStatus);
            panel3.Controls.Add(btnClose);
            panel3.Controls.Add(btnClaim);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 613);
            panel3.Name = "panel3";
            panel3.Size = new Size(1684, 180);
            panel3.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(1258, 81);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(201, 38);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Total:  0 items";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(220, 38, 38);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(844, 58);
            btnClose.Margin = new Padding(4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(236, 90);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnClaim
            // 
            btnClaim.BackColor = Color.DarkCyan;
            btnClaim.FlatStyle = FlatStyle.Flat;
            btnClaim.ForeColor = Color.White;
            btnClaim.Location = new Point(386, 58);
            btnClaim.Margin = new Padding(4);
            btnClaim.Name = "btnClaim";
            btnClaim.Size = new Size(236, 90);
            btnClaim.TabIndex = 4;
            btnClaim.Text = "Claim This Item";
            btnClaim.UseVisualStyleBackColor = false;
            btnClaim.Click += btnClaim_Click;
            // 
            // frmSearchItems
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1684, 793);
            Controls.Add(panel3);
            Controls.Add(dgvItems);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "frmSearchItems";
            Text = "Search Items";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnClear;
        private DataGridView dgvItems;
        private Panel panel3;
        private Button btnClose;
        private Button btnClaim;
        private Label lblStatus;
    }
}