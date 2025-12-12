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
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
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
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.LightBlue;
            this.buttonAgregar.BackgroundImage = global::DesktopKalendula.Properties.Resources.mas;
            this.buttonAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAgregar.Location = new System.Drawing.Point(96, 173);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(30, 33);
            this.buttonAgregar.TabIndex = 9;
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.LightBlue;
            this.buttonEliminar.BackgroundImage = global::DesktopKalendula.Properties.Resources.delete;
            this.buttonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.ForeColor = System.Drawing.Color.Transparent;
            this.buttonEliminar.Location = new System.Drawing.Point(168, 173);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(30, 33);
            this.buttonEliminar.TabIndex = 8;
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.LightBlue;
            this.buttonEditar.BackgroundImage = global::DesktopKalendula.Properties.Resources.editing;
            this.buttonEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.ForeColor = System.Drawing.Color.Transparent;
            this.buttonEditar.Location = new System.Drawing.Point(132, 173);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(30, 33);
            this.buttonEditar.TabIndex = 7;
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // ProjectHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonEditar);
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
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonAgregar;
    }
}