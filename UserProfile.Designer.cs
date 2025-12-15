namespace DesktopKalendula
{
    partial class UserProfile
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
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(332, 67);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "button1";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(23)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(52, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "My profile";
            // 
            // pbAvatar
            // 
            this.pbAvatar.Location = new System.Drawing.Point(3, 30);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(200, 200);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 2;
            this.pbAvatar.TabStop = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(176, 1);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(200, 40);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Edit Info";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(81, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 40);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Close";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserProfile";
            this.Text = "UserProfile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCerrar;
    }
}