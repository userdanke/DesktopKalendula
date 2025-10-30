namespace DesktopKalendula
{
    partial class FirstLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstLogin));
            this.lblk = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.btnsignup = new System.Windows.Forms.Button();
            this.btnsignin = new System.Windows.Forms.Button();
            this.acento = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acento)).BeginInit();
            this.SuspendLayout();
            // 
            // lblk
            // 
            resources.ApplyResources(this.lblk, "lblk");
            this.lblk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(23)))), ((int)(((byte)(0)))));
            this.lblk.Name = "lblk";
            this.lblk.Click += new System.EventHandler(this.lblk_Click);
            // 
            // Logo
            // 
            resources.ApplyResources(this.Logo, "Logo");
            this.Logo.Name = "Logo";
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.FirstLogin_Load);
            // 
            // btnsignup
            // 
            this.btnsignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            resources.ApplyResources(this.btnsignup, "btnsignup");
            this.btnsignup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.UseVisualStyleBackColor = false;
            // 
            // btnsignin
            // 
            this.btnsignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(163)))), ((int)(((byte)(193)))));
            resources.ApplyResources(this.btnsignin, "btnsignin");
            this.btnsignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.btnsignin.Name = "btnsignin";
            this.btnsignin.UseVisualStyleBackColor = false;
            // 
            // acento
            // 
            resources.ApplyResources(this.acento, "acento");
            this.acento.Name = "acento";
            this.acento.TabStop = false;
            // 
            // FirstLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.acento);
            this.Controls.Add(this.btnsignin);
            this.Controls.Add(this.btnsignup);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.lblk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FirstLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FirstLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblk;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button btnsignup;
        private System.Windows.Forms.Button btnsignin;
        private System.Windows.Forms.PictureBox acento;
    }
}