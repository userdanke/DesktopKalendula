namespace DesktopKalendula
{
    partial class ProjectHome
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
            this.buttonCrearTarea = new System.Windows.Forms.Button();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.buttonEditProject = new System.Windows.Forms.Button();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelDescriptionProject = new System.Windows.Forms.Label();
            this.labelNameProject = new System.Windows.Forms.Label();
            this.labelTitulo2 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(350, 209);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(101, 33);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "button1";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // buttonCrearTarea
            // 
            this.buttonCrearTarea.BackColor = System.Drawing.Color.White;
            this.buttonCrearTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrearTarea.Location = new System.Drawing.Point(59, 329);
            this.buttonCrearTarea.Name = "buttonCrearTarea";
            this.buttonCrearTarea.Size = new System.Drawing.Size(75, 23);
            this.buttonCrearTarea.TabIndex = 6;
            this.buttonCrearTarea.Text = "Add Task";
            this.buttonCrearTarea.UseVisualStyleBackColor = false;
            this.buttonCrearTarea.Click += new System.EventHandler(this.buttonCrearTarea_Click);
            // 
            // panelDetails
            // 
            this.panelDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            this.panelDetails.Controls.Add(this.buttonEditProject);
            this.panelDetails.Controls.Add(this.labelEndDate);
            this.panelDetails.Controls.Add(this.labelStartDate);
            this.panelDetails.Controls.Add(this.labelDescriptionProject);
            this.panelDetails.Controls.Add(this.labelNameProject);
            this.panelDetails.Controls.Add(this.labelTitulo2);
            this.panelDetails.Controls.Add(this.buttonCrearTarea);
            this.panelDetails.Location = new System.Drawing.Point(214, 304);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(200, 456);
            this.panelDetails.TabIndex = 10;
            // 
            // buttonEditProject
            // 
            this.buttonEditProject.BackColor = System.Drawing.Color.White;
            this.buttonEditProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditProject.Location = new System.Drawing.Point(59, 369);
            this.buttonEditProject.Name = "buttonEditProject";
            this.buttonEditProject.Size = new System.Drawing.Size(75, 23);
            this.buttonEditProject.TabIndex = 7;
            this.buttonEditProject.Text = "Edit Project";
            this.buttonEditProject.UseVisualStyleBackColor = false;
            this.buttonEditProject.Click += new System.EventHandler(this.buttonEditProject_Click);
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(55, 313);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(35, 13);
            this.labelEndDate.TabIndex = 4;
            this.labelEndDate.Text = "label1";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(99, 258);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(35, 13);
            this.labelStartDate.TabIndex = 3;
            this.labelStartDate.Text = "label1";
            // 
            // labelDescriptionProject
            // 
            this.labelDescriptionProject.AutoSize = true;
            this.labelDescriptionProject.Location = new System.Drawing.Point(99, 219);
            this.labelDescriptionProject.Name = "labelDescriptionProject";
            this.labelDescriptionProject.Size = new System.Drawing.Size(35, 13);
            this.labelDescriptionProject.TabIndex = 2;
            this.labelDescriptionProject.Text = "label1";
            // 
            // labelNameProject
            // 
            this.labelNameProject.AutoSize = true;
            this.labelNameProject.Location = new System.Drawing.Point(108, 174);
            this.labelNameProject.Name = "labelNameProject";
            this.labelNameProject.Size = new System.Drawing.Size(35, 13);
            this.labelNameProject.TabIndex = 1;
            this.labelNameProject.Text = "label1";
            // 
            // labelTitulo2
            // 
            this.labelTitulo2.AutoSize = true;
            this.labelTitulo2.Location = new System.Drawing.Point(97, 62);
            this.labelTitulo2.Name = "labelTitulo2";
            this.labelTitulo2.Size = new System.Drawing.Size(91, 13);
            this.labelTitulo2.TabIndex = 0;
            this.labelTitulo2.Text = "PROJECT HOME";
            // 
            // Logo
            // 
            this.Logo.Image = global::DesktopKalendula.Properties.Resources.Logo;
            this.Logo.Location = new System.Drawing.Point(49, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(365, 119);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 11;
            this.Logo.TabStop = false;
            // 
            // ProjectHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(800, 807);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.btnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjectHome";
            this.Text = "OpenProject";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OpenProject_Load);
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button buttonCrearTarea;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label labelTitulo2;
        private System.Windows.Forms.Label labelNameProject;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelDescriptionProject;
        private System.Windows.Forms.Button buttonEditProject;
    }
}