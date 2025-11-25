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
            this.buttonCrearTarea.Location = new System.Drawing.Point(559, 130);
            this.buttonCrearTarea.Name = "buttonCrearTarea";
            this.buttonCrearTarea.Size = new System.Drawing.Size(75, 23);
            this.buttonCrearTarea.TabIndex = 6;
            this.buttonCrearTarea.Text = "Add Task";
            this.buttonCrearTarea.UseVisualStyleBackColor = true;
            this.buttonCrearTarea.Click += new System.EventHandler(this.buttonCrearTarea_Click);
            // 
            // ProjectHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCrearTarea);
            this.Controls.Add(this.btnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjectHome";
            this.Text = "OpenProject";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OpenProject_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button buttonCrearTarea;
    }
}