namespace DesktopKalendula
{
    partial class PerfilManager
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
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonEditarDatos = new System.Windows.Forms.Button();
            this.buttonPendientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(12, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "btnMenu";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(108, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(200, 100);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonEditarDatos
            // 
            this.buttonEditarDatos.AutoSize = true;
            this.buttonEditarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(163)))), ((int)(((byte)(193)))));
            this.buttonEditarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditarDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.buttonEditarDatos.Location = new System.Drawing.Point(386, 45);
            this.buttonEditarDatos.Name = "buttonEditarDatos";
            this.buttonEditarDatos.Size = new System.Drawing.Size(150, 50);
            this.buttonEditarDatos.TabIndex = 8;
            this.buttonEditarDatos.Text = "Editar Datos";
            this.buttonEditarDatos.UseVisualStyleBackColor = false;
            this.buttonEditarDatos.Click += new System.EventHandler(this.buttonEditarDatos_Click);
            // 
            // buttonPendientes
            // 
            this.buttonPendientes.AutoSize = true;
            this.buttonPendientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(163)))), ((int)(((byte)(193)))));
            this.buttonPendientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPendientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.buttonPendientes.Location = new System.Drawing.Point(538, 45);
            this.buttonPendientes.Name = "buttonPendientes";
            this.buttonPendientes.Size = new System.Drawing.Size(150, 50);
            this.buttonPendientes.TabIndex = 9;
            this.buttonPendientes.Text = "Pendientes";
            this.buttonPendientes.UseVisualStyleBackColor = false;
            // 
            // PerfilManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPendientes);
            this.Controls.Add(this.buttonEditarDatos);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.btnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PerfilManager";
            this.Text = "PerfilManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PerfilManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonEditarDatos;
        private System.Windows.Forms.Button buttonPendientes;
    }
}