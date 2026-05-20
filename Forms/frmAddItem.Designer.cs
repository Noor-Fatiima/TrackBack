namespace TrackBack.Forms
{
    partial class frmAddItem
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
            lblTitle = new Label();
            grpItemType = new GroupBox();
            rbFound = new RadioButton();
            rbLost = new RadioButton();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            cmbLocation = new ComboBox();
            lblLocation = new Label();
            label1 = new Label();
            txtItemTitle = new TextBox();
            txtDescription = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dtpDateOccurred = new DateTimePicker();
            btnSubmit = new Button();
            btnCancel = new Button();
            panel1.SuspendLayout();
            grpItemType.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1578, 182);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(681, 58);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(312, 67);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Report Item";
            // 
            // grpItemType
            // 
            grpItemType.Controls.Add(rbFound);
            grpItemType.Controls.Add(rbLost);
            grpItemType.Location = new Point(120, 261);
            grpItemType.Name = "grpItemType";
            grpItemType.Size = new Size(1097, 133);
            grpItemType.TabIndex = 1;
            grpItemType.TabStop = false;
            grpItemType.Text = "Item Type";
            // 
            // rbFound
            // 
            rbFound.AutoSize = true;
            rbFound.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            rbFound.Location = new Point(694, 55);
            rbFound.Name = "rbFound";
            rbFound.Size = new Size(156, 34);
            rbFound.TabIndex = 1;
            rbFound.TabStop = true;
            rbFound.Text = "Found Item";
            rbFound.UseVisualStyleBackColor = true;
            // 
            // rbLost
            // 
            rbLost.AutoSize = true;
            rbLost.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            rbLost.Location = new Point(153, 55);
            rbLost.Name = "rbLost";
            rbLost.Size = new Size(135, 34);
            rbLost.TabIndex = 0;
            rbLost.TabStop = true;
            rbLost.Text = "Lost Item";
            rbLost.UseVisualStyleBackColor = true;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(52, 453);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(109, 30);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(248, 451);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(332, 38);
            cmbCategory.TabIndex = 3;
            // 
            // cmbLocation
            // 
            cmbLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLocation.FormattingEnabled = true;
            cmbLocation.Location = new Point(977, 445);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.Size = new Size(332, 38);
            cmbLocation.TabIndex = 7;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(781, 451);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(101, 30);
            lblLocation.TabIndex = 6;
            lblLocation.Text = "Location";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 538);
            label1.Name = "label1";
            label1.Size = new Size(113, 30);
            label1.TabIndex = 8;
            label1.Text = "Item Title";
            // 
            // txtItemTitle
            // 
            txtItemTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtItemTitle.Location = new Point(248, 534);
            txtItemTitle.Name = "txtItemTitle";
            txtItemTitle.Size = new Size(341, 34);
            txtItemTitle.TabIndex = 9;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.Location = new Point(977, 538);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(341, 104);
            txtDescription.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(781, 535);
            label3.Name = "label3";
            label3.Size = new Size(132, 30);
            label3.TabIndex = 10;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 628);
            label4.Name = "label4";
            label4.Size = new Size(164, 30);
            label4.TabIndex = 12;
            label4.Text = "Date Occurred";
            // 
            // dtpDateOccurred
            // 
            dtpDateOccurred.Location = new Point(244, 628);
            dtpDateOccurred.Name = "dtpDateOccurred";
            dtpDateOccurred.Size = new Size(336, 37);
            dtpDateOccurred.TabIndex = 14;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.SteelBlue;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(515, 699);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(216, 78);
            btnSubmit.TabIndex = 15;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(220, 38, 38);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(910, 699);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(236, 78);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmAddItem
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1578, 789);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(dtpDateOccurred);
            Controls.Add(label4);
            Controls.Add(txtDescription);
            Controls.Add(label3);
            Controls.Add(txtItemTitle);
            Controls.Add(label1);
            Controls.Add(cmbLocation);
            Controls.Add(lblLocation);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
            Controls.Add(grpItemType);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "frmAddItem";
            Text = "Add Item";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grpItemType.ResumeLayout(false);
            grpItemType.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private GroupBox grpItemType;
        private RadioButton rbFound;
        private RadioButton rbLost;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private ComboBox cmbLocation;
        private Label lblLocation;
        private Label label1;
        private TextBox txtItemTitle;
        private TextBox txtDescription;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpDateOccurred;
        private Button btnSubmit;
        private Button btnCancel;
    }
}