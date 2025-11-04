namespace DesktopKalendula
{
    partial class Home
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
            this.panelPrincipalMenu = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.labelHome = new System.Windows.Forms.Label();
            this.buttonNewProject = new System.Windows.Forms.Button();
            this.buttonOpenProject = new System.Windows.Forms.Button();
            this.buttonTask = new System.Windows.Forms.Button();
            this.panelSecundario = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.labelCalendar = new System.Windows.Forms.Label();
            this.panelPrincipalMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panelSecundario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipalMenu
            // 
            this.panelPrincipalMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            this.panelPrincipalMenu.Controls.Add(this.buttonTask);
            this.panelPrincipalMenu.Controls.Add(this.buttonOpenProject);
            this.panelPrincipalMenu.Controls.Add(this.buttonNewProject);
            this.panelPrincipalMenu.Controls.Add(this.labelHome);
            this.panelPrincipalMenu.Location = new System.Drawing.Point(135, 247);
            this.panelPrincipalMenu.Name = "panelPrincipalMenu";
            this.panelPrincipalMenu.Size = new System.Drawing.Size(349, 263);
            this.panelPrincipalMenu.TabIndex = 1;
            // 
            // Logo
            // 
            this.Logo.Image = global::DesktopKalendula.Properties.Resources.Logo;
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(365, 119);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Location = new System.Drawing.Point(94, 93);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(39, 13);
            this.labelHome.TabIndex = 0;
            this.labelHome.Text = "HOME";
            // 
            // buttonNewProject
            // 
            this.buttonNewProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.buttonNewProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewProject.Location = new System.Drawing.Point(20, 120);
            this.buttonNewProject.Name = "buttonNewProject";
            this.buttonNewProject.Size = new System.Drawing.Size(127, 33);
            this.buttonNewProject.TabIndex = 1;
            this.buttonNewProject.Text = "New project";
            this.buttonNewProject.UseVisualStyleBackColor = false;
            // 
            // buttonOpenProject
            // 
            this.buttonOpenProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.buttonOpenProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenProject.Location = new System.Drawing.Point(20, 159);
            this.buttonOpenProject.Name = "buttonOpenProject";
            this.buttonOpenProject.Size = new System.Drawing.Size(127, 33);
            this.buttonOpenProject.TabIndex = 2;
            this.buttonOpenProject.Text = "Open a project";
            this.buttonOpenProject.UseVisualStyleBackColor = false;
            // 
            // buttonTask
            // 
            this.buttonTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.buttonTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTask.Location = new System.Drawing.Point(20, 198);
            this.buttonTask.Name = "buttonTask";
            this.buttonTask.Size = new System.Drawing.Size(127, 33);
            this.buttonTask.TabIndex = 3;
            this.buttonTask.Text = "Task Management";
            this.buttonTask.UseVisualStyleBackColor = false;
            // 
            // panelSecundario
            // 
            this.panelSecundario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            this.panelSecundario.Controls.Add(this.monthCalendar1);
            this.panelSecundario.Controls.Add(this.labelCalendar);
            this.panelSecundario.Location = new System.Drawing.Point(517, 282);
            this.panelSecundario.Name = "panelSecundario";
            this.panelSecundario.Size = new System.Drawing.Size(304, 312);
            this.panelSecundario.TabIndex = 5;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(779, 237);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(101, 33);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "button1";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.monthCalendar1.Location = new System.Drawing.Point(51, 124);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(15);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // labelCalendar
            // 
            this.labelCalendar.AutoSize = true;
            this.labelCalendar.Location = new System.Drawing.Point(89, 100);
            this.labelCalendar.Name = "labelCalendar";
            this.labelCalendar.Size = new System.Drawing.Size(49, 13);
            this.labelCalendar.TabIndex = 0;
            this.labelCalendar.Text = "Calendar";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panelSecundario);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.panelPrincipalMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelPrincipalMenu.ResumeLayout(false);
            this.panelPrincipalMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panelSecundario.ResumeLayout(false);
            this.panelSecundario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelPrincipalMenu;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Button buttonTask;
        private System.Windows.Forms.Button buttonOpenProject;
        private System.Windows.Forms.Button buttonNewProject;
        private System.Windows.Forms.Panel panelSecundario;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label labelCalendar;
    }
}