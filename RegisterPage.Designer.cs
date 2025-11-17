namespace DesktopKalendula
{
    partial class RegisterPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPage));
            this.lblsignup = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panelrosa = new System.Windows.Forms.Panel();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panelrosa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblsignup
            // 
            this.lblsignup.AutoSize = true;
            this.lblsignup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(23)))), ((int)(((byte)(0)))));
            this.lblsignup.Location = new System.Drawing.Point(12, 9);
            this.lblsignup.Name = "lblsignup";
            this.lblsignup.Size = new System.Drawing.Size(51, 13);
            this.lblsignup.TabIndex = 0;
            this.lblsignup.Text = "SIGN UP";
            this.lblsignup.Click += new System.EventHandler(this.RegisterPage_Load);
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Logo.Location = new System.Drawing.Point(69, 9);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(130, 170);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 2;
            this.Logo.TabStop = false;
            // 
            // panelrosa
            // 
            this.panelrosa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.panelrosa.Controls.Add(this.lblConfirmPassword);
            this.panelrosa.Controls.Add(this.lblPassword);
            this.panelrosa.Controls.Add(this.lblEmail);
            this.panelrosa.Controls.Add(this.lblLastName);
            this.panelrosa.Controls.Add(this.lblFirstName);
            this.panelrosa.Controls.Add(this.btnSignUp);
            this.panelrosa.Controls.Add(this.txtPassword);
            this.panelrosa.Controls.Add(this.txtEmail);
            this.panelrosa.Controls.Add(this.txtConfirmPassword);
            this.panelrosa.Controls.Add(this.txtLastName);
            this.panelrosa.Controls.Add(this.txtFirstName);
            this.panelrosa.Location = new System.Drawing.Point(218, 10);
            this.panelrosa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelrosa.Name = "panelrosa";
            this.panelrosa.Size = new System.Drawing.Size(525, 609);
            this.panelrosa.TabIndex = 3;
            this.panelrosa.Paint += new System.Windows.Forms.PaintEventHandler(this.panelrosa_Paint);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnSignUp.Location = new System.Drawing.Point(188, 373);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(142, 57);
            this.btnSignUp.TabIndex = 5;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Location = new System.Drawing.Point(10, 226);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(488, 40);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Location = new System.Drawing.Point(10, 169);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(488, 40);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Location = new System.Drawing.Point(10, 283);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConfirmPassword.Multiline = true;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(488, 40);
            this.txtConfirmPassword.TabIndex = 2;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Location = new System.Drawing.Point(10, 99);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(488, 40);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Location = new System.Drawing.Point(10, 33);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(488, 40);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(7, 18);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(10, 75);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Last Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(10, 141);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(10, 211);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(7, 268);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(91, 13);
            this.lblConfirmPassword.TabIndex = 10;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(885, 639);
            this.Controls.Add(this.panelrosa);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.lblsignup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterPage";
            this.Text = "RegisterPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RegisterPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panelrosa.ResumeLayout(false);
            this.panelrosa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsignup;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panelrosa;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
    }
}