namespace TrackBack.Forms
{
    partial class frmLogin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lnkRegister = new LinkLabel();
            btnLogin = new Button();
            btnCancel = new Button();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(104, 17);
            label1.Name = "label1";
            label1.Size = new Size(187, 48);
            label1.TabIndex = 0;
            label1.Text = "TrackBack";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(39, 65);
            label2.Name = "label2";
            label2.Size = new Size(299, 32);
            label2.TabIndex = 1;
            label2.Text = "Lost and Found Manager";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.FromArgb(30, 41, 59);
            label3.Location = new Point(34, 196);
            label3.Name = "label3";
            label3.Size = new Size(71, 32);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(34, 264);
            label4.Name = "label4";
            label4.Size = new Size(111, 32);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // lnkRegister
            // 
            lnkRegister.ActiveLinkColor = Color.RoyalBlue;
            lnkRegister.AutoSize = true;
            lnkRegister.Font = new Font("Segoe UI", 11F);
            lnkRegister.LinkColor = SystemColors.Highlight;
            lnkRegister.Location = new Point(53, 452);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(342, 30);
            lnkRegister.TabIndex = 4;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "Don't have account? Register here\r\n";
            lnkRegister.LinkClicked += lnkRegister_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SteelBlue;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(34, 344);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(132, 59);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(220, 38, 38);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(251, 344);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(137, 59);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(168, 196);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(220, 31);
            txtEmail.TabIndex = 7;
            txtEmail.Text = "a.dmin@gmail.com";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(168, 264);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(220, 31);
            txtPassword.TabIndex = 8;
            txtPassword.Text = "admin123";
            txtPassword.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 132);
            panel1.TabIndex = 9;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(429, 523);
            Controls.Add(panel1);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(lnkRegister);
            Controls.Add(label4);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrackBack - Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private LinkLabel lnkRegister;
        private Button btnLogin;
        private Button btnCancel;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Panel panel1;
    }
}