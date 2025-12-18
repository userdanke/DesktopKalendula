namespace DesktopKalendula
{
    partial class CreateTask
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
            this.mtbHoursDedicated = new System.Windows.Forms.MaskedTextBox();
            this.labelHoursDedicated = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelUsuarios = new System.Windows.Forms.Label();
            this.labelAñadirUsuarios = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.textBoxDescripcionTarea = new System.Windows.Forms.TextBox();
            this.textBoxNombreTarea = new System.Windows.Forms.TextBox();
            this.labelFechaFin = new System.Windows.Forms.Label();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.labelDescripcionTarea = new System.Windows.Forms.Label();
            this.labelNombreTarea = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFormulario
            // 
            this.panelFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.panelFormulario.Controls.Add(this.mtbHoursDedicated);
            this.panelFormulario.Controls.Add(this.labelHoursDedicated);
            this.panelFormulario.Controls.Add(this.comboBoxEstado);
            this.panelFormulario.Controls.Add(this.labelEstado);
            this.panelFormulario.Controls.Add(this.labelUsuarios);
            this.panelFormulario.Controls.Add(this.labelAñadirUsuarios);
            this.panelFormulario.Controls.Add(this.buttonCancelar);
            this.panelFormulario.Controls.Add(this.buttonCrear);
            this.panelFormulario.Controls.Add(this.dateTimePickerFin);
            this.panelFormulario.Controls.Add(this.dateTimePickerInicio);
            this.panelFormulario.Controls.Add(this.textBoxDescripcionTarea);
            this.panelFormulario.Controls.Add(this.textBoxNombreTarea);
            this.panelFormulario.Controls.Add(this.labelFechaFin);
            this.panelFormulario.Controls.Add(this.labelFechaInicio);
            this.panelFormulario.Controls.Add(this.labelDescripcionTarea);
            this.panelFormulario.Controls.Add(this.labelNombreTarea);
            this.panelFormulario.Controls.Add(this.labelTitulo);
            this.panelFormulario.Location = new System.Drawing.Point(205, 73);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(871, 830);
            this.panelFormulario.TabIndex = 1;
            // 
            // mtbHoursDedicated
            // 
            this.mtbHoursDedicated.Location = new System.Drawing.Point(95, 602);
            this.mtbHoursDedicated.Mask = "00:00";
            this.mtbHoursDedicated.Name = "mtbHoursDedicated";
            this.mtbHoursDedicated.Size = new System.Drawing.Size(51, 20);
            this.mtbHoursDedicated.TabIndex = 19;
            this.mtbHoursDedicated.ValidatingType = typeof(System.DateTime);
            // 
            // labelHoursDedicated
            // 
            this.labelHoursDedicated.AutoSize = true;
            this.labelHoursDedicated.Location = new System.Drawing.Point(91, 586);
            this.labelHoursDedicated.Name = "labelHoursDedicated";
            this.labelHoursDedicated.Size = new System.Drawing.Size(85, 13);
            this.labelHoursDedicated.TabIndex = 17;
            this.labelHoursDedicated.Text = "Hours dedicated";
            this.labelHoursDedicated.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(94, 424);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEstado.TabIndex = 15;
            this.comboBoxEstado.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstado_SelectedIndexChanged);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(91, 408);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(32, 13);
            this.labelEstado.TabIndex = 13;
            this.labelEstado.Text = "State";
            // 
            // labelUsuarios
            // 
            this.labelUsuarios.AutoSize = true;
            this.labelUsuarios.Location = new System.Drawing.Point(93, 459);
            this.labelUsuarios.Name = "labelUsuarios";
            this.labelUsuarios.Size = new System.Drawing.Size(54, 13);
            this.labelUsuarios.TabIndex = 12;
            this.labelUsuarios.Text = "Add users";
            // 
            // labelAñadirUsuarios
            // 
            this.labelAñadirUsuarios.AutoSize = true;
            this.labelAñadirUsuarios.Location = new System.Drawing.Point(91, 408);
            this.labelAñadirUsuarios.Name = "labelAñadirUsuarios";
            this.labelAñadirUsuarios.Size = new System.Drawing.Size(0, 13);
            this.labelAñadirUsuarios.TabIndex = 11;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Location = new System.Drawing.Point(397, 683);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(119, 23);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancel";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonCrear
            // 
            this.buttonCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrear.Location = new System.Drawing.Point(92, 670);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(119, 23);
            this.buttonCrear.TabIndex = 9;
            this.buttonCrear.Text = "Create task";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.dateTimePickerFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFin.Location = new System.Drawing.Point(94, 373);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(343, 20);
            this.dateTimePickerFin.TabIndex = 8;
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.dateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInicio.Location = new System.Drawing.Point(94, 305);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(343, 20);
            this.dateTimePickerInicio.TabIndex = 7;
            // 
            // textBoxDescripcionTarea
            // 
            this.textBoxDescripcionTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.textBoxDescripcionTarea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescripcionTarea.Location = new System.Drawing.Point(94, 191);
            this.textBoxDescripcionTarea.Multiline = true;
            this.textBoxDescripcionTarea.Name = "textBoxDescripcionTarea";
            this.textBoxDescripcionTarea.Size = new System.Drawing.Size(343, 78);
            this.textBoxDescripcionTarea.TabIndex = 6;
            // 
            // textBoxNombreTarea
            // 
            this.textBoxNombreTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.textBoxNombreTarea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombreTarea.Location = new System.Drawing.Point(92, 147);
            this.textBoxNombreTarea.Name = "textBoxNombreTarea";
            this.textBoxNombreTarea.Size = new System.Drawing.Size(343, 13);
            this.textBoxNombreTarea.TabIndex = 5;
            // 
            // labelFechaFin
            // 
            this.labelFechaFin.AutoSize = true;
            this.labelFechaFin.Location = new System.Drawing.Point(91, 345);
            this.labelFechaFin.Name = "labelFechaFin";
            this.labelFechaFin.Size = new System.Drawing.Size(52, 13);
            this.labelFechaFin.TabIndex = 4;
            this.labelFechaFin.Text = "End Date";
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Location = new System.Drawing.Point(91, 285);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(55, 13);
            this.labelFechaInicio.TabIndex = 3;
            this.labelFechaInicio.Text = "Start Date";
            // 
            // labelDescripcionTarea
            // 
            this.labelDescripcionTarea.AutoSize = true;
            this.labelDescripcionTarea.Location = new System.Drawing.Point(89, 175);
            this.labelDescripcionTarea.Name = "labelDescripcionTarea";
            this.labelDescripcionTarea.Size = new System.Drawing.Size(60, 13);
            this.labelDescripcionTarea.TabIndex = 2;
            this.labelDescripcionTarea.Text = "Description";
            // 
            // labelNombreTarea
            // 
            this.labelNombreTarea.AutoSize = true;
            this.labelNombreTarea.Location = new System.Drawing.Point(89, 124);
            this.labelNombreTarea.Name = "labelNombreTarea";
            this.labelNombreTarea.Size = new System.Drawing.Size(38, 13);
            this.labelNombreTarea.TabIndex = 1;
            this.labelNombreTarea.Text = "Name ";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(229, 54);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(81, 13);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Add a new task";
            // 
            // CreateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1332, 827);
            this.Controls.Add(this.panelFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateTask";
            this.Text = "CreateTask";
            this.Load += new System.EventHandler(this.CreateTask_Load);
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.Label labelAñadirUsuarios;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.TextBox textBoxDescripcionTarea;
        private System.Windows.Forms.TextBox textBoxNombreTarea;
        private System.Windows.Forms.Label labelFechaFin;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.Label labelDescripcionTarea;
        private System.Windows.Forms.Label labelNombreTarea;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelUsuarios;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label labelHoursDedicated;
        private System.Windows.Forms.MaskedTextBox mtbHoursDedicated;
    }
}