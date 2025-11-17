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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstLogin));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.btnsignup = new System.Windows.Forms.Button();
            this.btnsignin = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
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
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click);
            // 
            // btnsignin
            // 
            this.btnsignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(163)))), ((int)(((byte)(193)))));
            resources.ApplyResources(this.btnsignin, "btnsignin");
            this.btnsignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.btnsignin.Name = "btnsignin";
            this.btnsignin.UseVisualStyleBackColor = false;
            this.btnsignin.Click += new System.EventHandler(this.btnsignin_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // FirstLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.btnsignin);
            this.Controls.Add(this.btnsignup);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FirstLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FirstLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button btnsignup;
        private System.Windows.Forms.Button btnsignin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}