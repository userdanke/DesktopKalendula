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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelPrincipalMenu = new System.Windows.Forms.Panel();
            this.buttonTask = new System.Windows.Forms.Button();
            this.buttonOpenProject = new System.Windows.Forms.Button();
            this.buttonNewProject = new System.Windows.Forms.Button();
            this.labelHome = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panelSecundario = new System.Windows.Forms.Panel();
            this.buttonSiguiente = new System.Windows.Forms.Button();
            this.buttonAnterior = new System.Windows.Forms.Button();
            this.lblMesAnio = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelCalendar = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.labelMessages = new System.Windows.Forms.Label();
            this.panelPrincipalMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panelSecundario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.buttonNewProject.Click += new System.EventHandler(this.buttonNewProject_Click);
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
            // panelSecundario
            // 
            this.panelSecundario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            this.panelSecundario.Controls.Add(this.labelMessages);
            this.panelSecundario.Controls.Add(this.buttonSiguiente);
            this.panelSecundario.Controls.Add(this.buttonAnterior);
            this.panelSecundario.Controls.Add(this.lblMesAnio);
            this.panelSecundario.Controls.Add(this.dataGridView1);
            this.panelSecundario.Controls.Add(this.labelCalendar);
            this.panelSecundario.Location = new System.Drawing.Point(517, 282);
            this.panelSecundario.Name = "panelSecundario";
            this.panelSecundario.Size = new System.Drawing.Size(304, 312);
            this.panelSecundario.TabIndex = 5;
            // 
            // buttonSiguiente
            // 
            this.buttonSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.buttonSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSiguiente.Location = new System.Drawing.Point(174, 119);
            this.buttonSiguiente.Name = "buttonSiguiente";
            this.buttonSiguiente.Size = new System.Drawing.Size(45, 38);
            this.buttonSiguiente.TabIndex = 7;
            this.buttonSiguiente.Text = ">";
            this.buttonSiguiente.UseVisualStyleBackColor = false;
            this.buttonSiguiente.Click += new System.EventHandler(this.buttonSiguiente_Click);
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.BackColor = System.Drawing.Color.Transparent;
            this.buttonAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnterior.Location = new System.Drawing.Point(88, 119);
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.Size = new System.Drawing.Size(45, 38);
            this.buttonAnterior.TabIndex = 6;
            this.buttonAnterior.Text = "<";
            this.buttonAnterior.UseVisualStyleBackColor = false;
            this.buttonAnterior.Click += new System.EventHandler(this.buttonAnterior_Click);
            // 
            // lblMesAnio
            // 
            this.lblMesAnio.AutoSize = true;
            this.lblMesAnio.Location = new System.Drawing.Point(139, 124);
            this.lblMesAnio.Name = "lblMesAnio";
            this.lblMesAnio.Size = new System.Drawing.Size(29, 13);
            this.lblMesAnio.TabIndex = 6;
            this.lblMesAnio.Text = "label";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("OCR A Extended", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(23)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(163)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.Location = new System.Drawing.Point(37, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(23)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(163)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(779, 237);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(101, 33);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "button1";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // labelMessages
            // 
            this.labelMessages.AutoSize = true;
            this.labelMessages.Location = new System.Drawing.Point(85, 183);
            this.labelMessages.Name = "labelMessages";
            this.labelMessages.Size = new System.Drawing.Size(65, 13);
            this.labelMessages.TabIndex = 8;
            this.labelMessages.Text = "Notifications";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label labelCalendar;
        private System.Windows.Forms.Label lblMesAnio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSiguiente;
        private System.Windows.Forms.Button buttonAnterior;
        private System.Windows.Forms.Label labelMessages;
    }
}