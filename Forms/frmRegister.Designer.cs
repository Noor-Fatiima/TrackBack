namespace TrackBack.Forms
{
    partial class frmRegister
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lnkBack = new LinkLabel();
            btnRegister = new Button();
            btnCancel = new Button();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtDepartment = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(32, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(473, 140);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(85, 45);
            label1.Name = "label1";
            label1.Size = new Size(295, 51);
            label1.TabIndex = 0;
            label1.Text = "Create Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(22, 215);
            label2.Name = "label2";
            label2.Size = new Size(110, 30);
            label2.TabIndex = 1;
            label2.Text = "Full Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(20, 284);
            label3.Name = "label3";
            label3.Size = new Size(64, 30);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(20, 354);
            label4.Name = "label4";
            label4.Size = new Size(74, 30);
            label4.TabIndex = 3;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(20, 419);
            label5.Name = "label5";
            label5.Size = new Size(129, 30);
            label5.TabIndex = 4;
            label5.Text = "Department";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(22, 483);
            label6.Name = "label6";
            label6.Size = new Size(103, 30);
            label6.TabIndex = 5;
            label6.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(15, 549);
            label7.Name = "label7";
            label7.Size = new Size(187, 30);
            label7.TabIndex = 6;
            label7.Text = "Confirm Password";
            // 
            // lnkBack
            // 
            lnkBack.AutoSize = true;
            lnkBack.Font = new Font("Segoe UI", 11F);
            lnkBack.LinkColor = SystemColors.Highlight;
            lnkBack.Location = new Point(76, 708);
            lnkBack.Name = "lnkBack";
            lnkBack.Size = new Size(371, 30);
            lnkBack.TabIndex = 7;
            lnkBack.TabStop = true;
            lnkBack.Text = "Already have an Account? Login here";
            lnkBack.LinkClicked += lnkBack_LinkClicked;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SteelBlue;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 11F);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(94, 629);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(119, 53);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(220, 38, 38);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(315, 629);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(123, 53);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Location = new Point(198, 216);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(307, 31);
            txtFullName.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(198, 283);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(307, 31);
            txtEmail.TabIndex = 11;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Location = new Point(198, 354);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(307, 31);
            txtPhone.TabIndex = 12;
            // 
            // txtDepartment
            // 
            txtDepartment.BorderStyle = BorderStyle.FixedSingle;
            txtDepartment.Location = new Point(198, 420);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(307, 31);
            txtDepartment.TabIndex = 13;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(198, 484);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(307, 31);
            txtPassword.TabIndex = 14;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Location = new Point(198, 548);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(307, 31);
            txtConfirmPassword.TabIndex = 15;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(527, 760);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtDepartment);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(lnkBack);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private LinkLabel lnkBack;
        private Button btnRegister;
        private Button btnCancel;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtDepartment;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
    }
}