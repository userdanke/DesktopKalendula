namespace DesktopKalendula
{
    partial class CreateProject
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
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.labelAñadirUsuarios = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonCrearProyecto = new System.Windows.Forms.Button();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.textBoxDescripcionProyecto = new System.Windows.Forms.TextBox();
            this.textBoxNombreProyecto = new System.Windows.Forms.TextBox();
            this.labelFechaFin = new System.Windows.Forms.Label();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.labelDescripcionProyecto = new System.Windows.Forms.Label();
            this.labelNombreProyecto = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFormulario
            // 
            this.panelFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.panelFormulario.Controls.Add(this.labelAñadirUsuarios);
            this.panelFormulario.Controls.Add(this.buttonCancelar);
            this.panelFormulario.Controls.Add(this.buttonCrearProyecto);
            this.panelFormulario.Controls.Add(this.dateTimePickerFin);
            this.panelFormulario.Controls.Add(this.dateTimePickerInicio);
            this.panelFormulario.Controls.Add(this.textBoxDescripcionProyecto);
            this.panelFormulario.Controls.Add(this.textBoxNombreProyecto);
            this.panelFormulario.Controls.Add(this.labelFechaFin);
            this.panelFormulario.Controls.Add(this.labelFechaInicio);
            this.panelFormulario.Controls.Add(this.labelDescripcionProyecto);
            this.panelFormulario.Controls.Add(this.labelNombreProyecto);
            this.panelFormulario.Controls.Add(this.labelTitulo);
            this.panelFormulario.Location = new System.Drawing.Point(128, 69);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(871, 830);
            this.panelFormulario.TabIndex = 0;
            // 
            // labelAñadirUsuarios
            // 
            this.labelAñadirUsuarios.AutoSize = true;
            this.labelAñadirUsuarios.Location = new System.Drawing.Point(91, 408);
            this.labelAñadirUsuarios.Name = "labelAñadirUsuarios";
            this.labelAñadirUsuarios.Size = new System.Drawing.Size(81, 13);
            this.labelAñadirUsuarios.TabIndex = 11;
            this.labelAñadirUsuarios.Text = "Añadir Usuarios";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Location = new System.Drawing.Point(365, 479);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(119, 23);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonCrearProyecto
            // 
            this.buttonCrearProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrearProyecto.Location = new System.Drawing.Point(94, 464);
            this.buttonCrearProyecto.Name = "buttonCrearProyecto";
            this.buttonCrearProyecto.Size = new System.Drawing.Size(119, 23);
            this.buttonCrearProyecto.TabIndex = 9;
            this.buttonCrearProyecto.Text = "Crear proyecto";
            this.buttonCrearProyecto.UseVisualStyleBackColor = true;
            this.buttonCrearProyecto.Click += new System.EventHandler(this.buttonCrearProyecto_Click);
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.dateTimePickerFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFin.Location = new System.Drawing.Point(94, 373);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(451, 20);
            this.dateTimePickerFin.TabIndex = 8;
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.dateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInicio.Location = new System.Drawing.Point(94, 305);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(451, 20);
            this.dateTimePickerInicio.TabIndex = 7;
            // 
            // textBoxDescripcionProyecto
            // 
            this.textBoxDescripcionProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.textBoxDescripcionProyecto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescripcionProyecto.Location = new System.Drawing.Point(94, 191);
            this.textBoxDescripcionProyecto.Multiline = true;
            this.textBoxDescripcionProyecto.Name = "textBoxDescripcionProyecto";
            this.textBoxDescripcionProyecto.Size = new System.Drawing.Size(449, 78);
            this.textBoxDescripcionProyecto.TabIndex = 6;
            // 
            // textBoxNombreProyecto
            // 
            this.textBoxNombreProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.textBoxNombreProyecto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombreProyecto.Location = new System.Drawing.Point(92, 147);
            this.textBoxNombreProyecto.Name = "textBoxNombreProyecto";
            this.textBoxNombreProyecto.Size = new System.Drawing.Size(451, 13);
            this.textBoxNombreProyecto.TabIndex = 5;
            // 
            // labelFechaFin
            // 
            this.labelFechaFin.AutoSize = true;
            this.labelFechaFin.Location = new System.Drawing.Point(91, 345);
            this.labelFechaFin.Name = "labelFechaFin";
            this.labelFechaFin.Size = new System.Drawing.Size(95, 13);
            this.labelFechaFin.TabIndex = 4;
            this.labelFechaFin.Text = "Fecha Finalización";
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Location = new System.Drawing.Point(91, 285);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(79, 13);
            this.labelFechaInicio.TabIndex = 3;
            this.labelFechaInicio.Text = "Fecha de inicio";
            this.labelFechaInicio.Click += new System.EventHandler(this.labelFechaInicio_Click);
            // 
            // labelDescripcionProyecto
            // 
            this.labelDescripcionProyecto.AutoSize = true;
            this.labelDescripcionProyecto.Location = new System.Drawing.Point(89, 175);
            this.labelDescripcionProyecto.Name = "labelDescripcionProyecto";
            this.labelDescripcionProyecto.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcionProyecto.TabIndex = 2;
            this.labelDescripcionProyecto.Text = "Descripcion";
            // 
            // labelNombreProyecto
            // 
            this.labelNombreProyecto.AutoSize = true;
            this.labelNombreProyecto.Location = new System.Drawing.Point(89, 124);
            this.labelNombreProyecto.Name = "labelNombreProyecto";
            this.labelNombreProyecto.Size = new System.Drawing.Size(105, 13);
            this.labelNombreProyecto.TabIndex = 1;
            this.labelNombreProyecto.Text = "Nombre del proyecto";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(229, 54);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(105, 13);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Create a new project";
            // 
            // CreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1290, 911);
            this.Controls.Add(this.panelFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateProject";
            this.Load += new System.EventHandler(this.CreateProject_Load);
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelDescripcionProyecto;
        private System.Windows.Forms.Label labelNombreProyecto;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.TextBox textBoxDescripcionProyecto;
        private System.Windows.Forms.TextBox textBoxNombreProyecto;
        private System.Windows.Forms.Label labelFechaFin;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonCrearProyecto;
        private System.Windows.Forms.Label labelAñadirUsuarios;
    }
}