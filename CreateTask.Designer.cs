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
            this.checkedListBoxUsuarios = new System.Windows.Forms.CheckedListBox();
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
            this.panelFormulario.Controls.Add(this.checkedListBoxUsuarios);
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
            this.panelFormulario.Location = new System.Drawing.Point(273, 90);
            this.panelFormulario.Margin = new System.Windows.Forms.Padding(4);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(847, 1022);
            this.panelFormulario.TabIndex = 1;
            // 
            // checkedListBoxUsuarios
            // 
            this.checkedListBoxUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.checkedListBoxUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBoxUsuarios.FormattingEnabled = true;
            this.checkedListBoxUsuarios.Location = new System.Drawing.Point(95, 485);
            this.checkedListBoxUsuarios.Name = "checkedListBoxUsuarios";
            this.checkedListBoxUsuarios.Size = new System.Drawing.Size(342, 92);
            this.checkedListBoxUsuarios.TabIndex = 20;
            // 
            // mtbHoursDedicated
            // 
            this.mtbHoursDedicated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.mtbHoursDedicated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbHoursDedicated.Location = new System.Drawing.Point(95, 602);
            this.mtbHoursDedicated.Mask = "00:00";
            this.mtbHoursDedicated.Name = "mtbHoursDedicated";
            this.mtbHoursDedicated.Size = new System.Drawing.Size(81, 22);
            this.mtbHoursDedicated.TabIndex = 19;
            this.mtbHoursDedicated.ValidatingType = typeof(System.DateTime);
            this.mtbHoursDedicated.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbHoursDedicated_MaskInputRejected);
            // 
            // labelHoursDedicated
            // 
            this.labelHoursDedicated.AutoSize = true;
            this.labelHoursDedicated.Location = new System.Drawing.Point(121, 721);
            this.labelHoursDedicated.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHoursDedicated.Name = "labelHoursDedicated";
            this.labelHoursDedicated.Size = new System.Drawing.Size(107, 16);
            this.labelHoursDedicated.TabIndex = 17;
            this.labelHoursDedicated.Text = "Hours dedicated";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(125, 522);
            this.comboBoxEstado.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(160, 24);
            this.comboBoxEstado.TabIndex = 15;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(121, 502);
            this.labelEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(38, 16);
            this.labelEstado.TabIndex = 13;
            this.labelEstado.Text = "State";
            // 
            // labelUsuarios
            // 
            this.labelUsuarios.AutoSize = true;
            this.labelUsuarios.Location = new System.Drawing.Point(124, 565);
            this.labelUsuarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsuarios.Name = "labelUsuarios";
            this.labelUsuarios.Size = new System.Drawing.Size(68, 16);
            this.labelUsuarios.TabIndex = 12;
            this.labelUsuarios.Text = "Add users";
            // 
            // labelAñadirUsuarios
            // 
            this.labelAñadirUsuarios.AutoSize = true;
            this.labelAñadirUsuarios.Location = new System.Drawing.Point(121, 502);
            this.labelAñadirUsuarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAñadirUsuarios.Name = "labelAñadirUsuarios";
            this.labelAñadirUsuarios.Size = new System.Drawing.Size(0, 16);
            this.labelAñadirUsuarios.TabIndex = 11;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Location = new System.Drawing.Point(529, 841);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(159, 28);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancel";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonCrear
            // 
            this.buttonCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrear.Location = new System.Drawing.Point(123, 825);
            this.buttonCrear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(159, 28);
            this.buttonCrear.TabIndex = 9;
            this.buttonCrear.Text = "Create task";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.dateTimePickerFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFin.Location = new System.Drawing.Point(125, 459);
            this.dateTimePickerFin.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(456, 22);
            this.dateTimePickerFin.TabIndex = 8;
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.dateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInicio.Location = new System.Drawing.Point(125, 375);
            this.dateTimePickerInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(456, 22);
            this.dateTimePickerInicio.TabIndex = 7;
            // 
            // textBoxDescripcionTarea
            // 
            this.textBoxDescripcionTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.textBoxDescripcionTarea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescripcionTarea.Location = new System.Drawing.Point(125, 235);
            this.textBoxDescripcionTarea.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescripcionTarea.Multiline = true;
            this.textBoxDescripcionTarea.Name = "textBoxDescripcionTarea";
            this.textBoxDescripcionTarea.Size = new System.Drawing.Size(457, 96);
            this.textBoxDescripcionTarea.TabIndex = 6;
            // 
            // textBoxNombreTarea
            // 
            this.textBoxNombreTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.textBoxNombreTarea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombreTarea.Location = new System.Drawing.Point(123, 181);
            this.textBoxNombreTarea.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombreTarea.Name = "textBoxNombreTarea";
            this.textBoxNombreTarea.Size = new System.Drawing.Size(457, 15);
            this.textBoxNombreTarea.TabIndex = 5;
            // 
            // labelFechaFin
            // 
            this.labelFechaFin.AutoSize = true;
            this.labelFechaFin.Location = new System.Drawing.Point(121, 425);
            this.labelFechaFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFechaFin.Name = "labelFechaFin";
            this.labelFechaFin.Size = new System.Drawing.Size(63, 16);
            this.labelFechaFin.TabIndex = 4;
            this.labelFechaFin.Text = "End Date";
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Location = new System.Drawing.Point(121, 351);
            this.labelFechaInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(66, 16);
            this.labelFechaInicio.TabIndex = 3;
            this.labelFechaInicio.Text = "Start Date";
            // 
            // labelDescripcionTarea
            // 
            this.labelDescripcionTarea.AutoSize = true;
            this.labelDescripcionTarea.Location = new System.Drawing.Point(119, 215);
            this.labelDescripcionTarea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescripcionTarea.Name = "labelDescripcionTarea";
            this.labelDescripcionTarea.Size = new System.Drawing.Size(75, 16);
            this.labelDescripcionTarea.TabIndex = 2;
            this.labelDescripcionTarea.Text = "Description";
            // 
            // labelNombreTarea
            // 
            this.labelNombreTarea.AutoSize = true;
            this.labelNombreTarea.Location = new System.Drawing.Point(119, 153);
            this.labelNombreTarea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombreTarea.Name = "labelNombreTarea";
            this.labelNombreTarea.Size = new System.Drawing.Size(47, 16);
            this.labelNombreTarea.TabIndex = 1;
            this.labelNombreTarea.Text = "Name ";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(305, 66);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(98, 16);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Add a new task";
            // 
            // CreateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1720, 1102);
            this.Controls.Add(this.panelFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.CheckedListBox checkedListBoxUsuarios;
    }
}