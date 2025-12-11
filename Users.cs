using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopKalendula.Diseño;

namespace DesktopKalendula
{
    public partial class Users : Form
    {
        private MenuLateral menu;
        private FlowLayoutPanel panelTarjetas;
        private ComboBox comboFiltros;

        public Users()
        {
            InitializeComponent();
            DiseñoForms diseño = new DiseñoForms();
            this.Controls.Add(diseño);
            ConfigurarMenu();


            UsersLogo.Location = new Point(850, 70);

            btnadd.Location = new Point(1450, 250);
            btnadd.Font = Fuentes.RubikSemiBold(15);

            buttonBuscar.Location = new Point(450, 250);
            buttonBuscar.Font = Fuentes.RubikBold(10);
            buttonBuscar.Click += buttonBuscar_Click;

            textBoxBuscar.Location = new Point(580, 250);
            textBoxBuscar.Font = Fuentes.RubikBold(18);

            buttonOrderBy.Location = new Point(110,250);
            buttonOrderBy.Font = Fuentes.RubikBold(10);

            comboBoxFiltro.Location = new Point(260,250);
            comboBoxFiltro.Font = Fuentes.RubikMedium(14);
        }

        private void Users_Load(object sender, EventArgs e)
        {
            if (panelTarjetas == null)
            {
                panelTarjetas = new FlowLayoutPanel();
                panelTarjetas.Location = new Point(70, 300);
                panelTarjetas.Size = new Size(1700, 800);
                panelTarjetas.AutoScroll = true;
                panelTarjetas.FlowDirection = FlowDirection.LeftToRight;
                panelTarjetas.WrapContents = true;
                panelTarjetas.Padding = new Padding(10);
                this.Controls.Add(panelTarjetas);
            }

            CargarTarjetasExistentes();

            ConfigurarComboBoxFiltros();


        }

        private void CrearTarjetaUsuario(InfoUser usuario)
        {
            string ruta = @"Diseño\LogoUser.png";

            Panel tarjeta = new Panel();
            tarjeta.Size = new Size(250, 250);
            tarjeta.BackColor = Color.White;
            tarjeta.BorderStyle = BorderStyle.None;
            tarjeta.Margin = new Padding(30);

            Button btnEliminar = new Button();
            btnEliminar.Text = "✕";
            btnEliminar.Size = new Size(30, 30);
            btnEliminar.Location = new Point(tarjeta.Width - 40, 5);
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.BackColor = Color.FromArgb(204, 163, 193);
            btnEliminar.ForeColor = Color.White;

            btnEliminar.Click += (s, args) =>
            {

                DialogResult resultado = MessageBox.Show($"¿Estás seguro de eliminar a {usuario.username}?\nEsta acción no se puede deshacer.",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    if (UsuarioManager.EliminarUsuario(usuario.id))
                    {
                        panelTarjetas.Controls.Remove(tarjeta);
                        MessageBox.Show("Usuario eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }

            };
            tarjeta.Controls.Add(btnEliminar);

            Button btnEditar = new Button();
            btnEditar.Text = "🖍";
            btnEditar.Size = new Size(30, 30);
            btnEditar.Location = new Point(tarjeta.Width - 80, 5);
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.BackColor = Color.FromArgb(211, 145, 109);
            btnEditar.ForeColor = Color.White;
            btnEditar.Click += (s, args) =>
        {
            MostrarPanelEdicion(usuario, tarjeta);
        };
            tarjeta.Controls.Add(btnEditar);

            TableLayoutPanel layout = new TableLayoutPanel();
            layout.Dock = DockStyle.Fill;
            layout.ColumnCount = 1;
            layout.RowCount = 4;
            layout.Padding = new Padding(10, 40, 10, 10);
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tarjeta.Controls.Add(layout);
            layout.SendToBack();


            PictureBox pictureBox = new PictureBox();
            if (System.IO.File.Exists(ruta))
                pictureBox.Image = Image.FromFile(ruta);
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox.Anchor = AnchorStyles.None;
            pictureBox.Margin = new Padding(0, 0, 0, 15);
            layout.Controls.Add(pictureBox, 0, 0);

            Label lblNombre = new Label();
            lblNombre.Text = usuario.username;
            lblNombre.Font = Fuentes.RubikSemiBold(14);
            lblNombre.ForeColor = Color.FromArgb(211, 145, 109);
            lblNombre.AutoSize = true;
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            lblNombre.Dock = DockStyle.Fill;
            layout.Controls.Add(lblNombre, 0, 1);

            Label lblEmail = new Label();
            lblEmail.Text = usuario.email;
            lblEmail.Font = Fuentes.RubikRegular(12);
            lblEmail.ForeColor = Color.FromArgb(211, 145, 109);
            lblEmail.AutoSize = true;
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            lblEmail.Dock = DockStyle.Fill;
            layout.Controls.Add(lblEmail, 0, 2);


            Label lblRol = new Label();
            lblRol.Text = $"Role: {usuario.role}";
            lblRol.Font = Fuentes.RubikRegular(12);
            lblRol.ForeColor = Color.FromArgb(204, 163, 193);
            lblRol.AutoSize = true;
            lblRol.TextAlign = ContentAlignment.MiddleCenter;
            lblRol.Dock = DockStyle.Fill;
            layout.Controls.Add(lblRol, 0, 3);

            panelTarjetas.Controls.Add(tarjeta);
        }
        private void CargarTarjetasExistentes()
        {
            List<InfoUser> usuarios = UsuarioManager.LeerUsuarios();

            foreach (InfoUser usuario in usuarios)
            {
                CrearTarjetaUsuario(usuario);

            }
        }

        private void MostrarPanelEdicion(InfoUser usuario, Panel tarjetaOriginal)
        {
            Panel panelEditar = new Panel();
            panelEditar.Size = new Size(600, 650);
            panelEditar.BackColor = Color.FromArgb(228, 235, 241);
            panelEditar.Location = new Point(
                (this.ClientSize.Width - panelEditar.Width) / 2,
                (this.ClientSize.Height - panelEditar.Height) / 2
            );
            panelEditar.BorderStyle = BorderStyle.FixedSingle;

            Label lblTitulo = new Label();
            lblTitulo.Text = "Edit User Information";
            lblTitulo.Font = Fuentes.RubikMedium(20);
            lblTitulo.ForeColor = Color.FromArgb(92, 135, 153);
            lblTitulo.AutoSize = true;
            panelEditar.Controls.Add(lblTitulo);
            lblTitulo.Left = (panelEditar.Width - lblTitulo.Width) / 2;
            lblTitulo.Top = 40;

            string[] labels = { "Name", "Email", "New Password (optional)", "Role" };
            TextBox[] textBoxes = new TextBox[4];
            int espacio = 120;

            for (int i = 0; i < labels.Length; i++)
            {
                Label lbl = new Label();
                lbl.Text = labels[i];
                lbl.Location = new Point(90, espacio);
                lbl.AutoSize = true;
                lbl.Font = Fuentes.RubikRegular(10);
                lbl.ForeColor = Color.FromArgb(92, 135, 153);
                panelEditar.Controls.Add(lbl);

                if (i == 3)
                {
                    System.Windows.Forms.ComboBox comboRol = new System.Windows.Forms.ComboBox();
                    comboRol.Location = new Point(90, espacio + 30);
                    comboRol.Width = 410;
                    comboRol.Font = Fuentes.RubikRegular(15);
                    comboRol.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboRol.Items.AddRange(new object[] { "Manager", "Developer" });
                    comboRol.SelectedItem = usuario.role;
                    comboRol.Tag = "rol";
                    panelEditar.Controls.Add(comboRol);
                }
                else
                {
                    TextBox txt = new TextBox();
                    txt.Location = new Point(90, espacio + 30);
                    txt.Width = 410;
                    txt.Height = 40;
                    txt.Font = Fuentes.RubikRegular(15);
                    txt.ForeColor = Color.FromArgb(61, 23, 0);
                    txt.BorderStyle = BorderStyle.None;


                    switch (i)
                    {
                        case 0: txt.Text = usuario.username; break;
                        case 1: txt.Text = usuario.email; break;
                        case 2:
                            txt.PasswordChar = '*';
                            break;
                    }

                    textBoxes[i] = txt;
                    panelEditar.Controls.Add(txt);
                }

                espacio += 70;
            }


            Button btnGuardar = new Button();
            btnGuardar.Text = "Save Changes";
            btnGuardar.Location = new Point(150, espacio + 50);
            btnGuardar.Width = 250;
            btnGuardar.Height = 50;
            btnGuardar.BackColor = Color.FromArgb(204, 163, 193);
            btnGuardar.Font = Fuentes.RubikRegular(15);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.FromArgb(252, 250, 249);

            btnGuardar.Click += (s, args) =>
            {
                string nuevoNombre = textBoxes[0].Text.Trim();
                string nuevoEmail = textBoxes[1].Text.Trim();
                string nuevaContraseña = textBoxes[2].Text.Trim();


                System.Windows.Forms.ComboBox comboRol = panelEditar.Controls
                    .OfType<System.Windows.Forms.ComboBox>()
                    .FirstOrDefault(c => c.Tag?.ToString() == "rol");
                string nuevoRol = comboRol?.SelectedItem?.ToString();


                if (string.IsNullOrWhiteSpace(nuevoNombre) || string.IsNullOrWhiteSpace(nuevoEmail))
                {
                    MessageBox.Show("Name and Email are required.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (nuevaContraseña == "Leave empty to keep current" || string.IsNullOrWhiteSpace(nuevaContraseña))
                {
                    nuevaContraseña = null;
                }


                if (UsuarioManager.EditarUsuario(usuario.id, nuevoNombre, nuevoEmail, nuevaContraseña, nuevoRol))
                {

                    ActualizarTarjeta(tarjetaOriginal, usuario.id);

                    panelEditar.Visible = false;
                    this.Controls.Remove(panelEditar);

                    MessageBox.Show("User updated successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
            panelEditar.Controls.Add(btnGuardar);

            Button btnCancelar = new Button();
            btnCancelar.Text = "Cancel";
            btnCancelar.Location = new Point(150, espacio + 120);
            btnCancelar.Width = 250;
            btnCancelar.Height = 50;
            btnCancelar.BackColor = Color.FromArgb(229, 122, 122);
            btnCancelar.Font = Fuentes.RubikRegular(15);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.FromArgb(252, 250, 249);
            btnCancelar.Click += (s, args) =>
            {
                panelEditar.Visible = false;
                this.Controls.Remove(panelEditar);
            };
            panelEditar.Controls.Add(btnCancelar);

            this.Controls.Add(panelEditar);
            panelEditar.BringToFront();
        }

        private void ActualizarTarjeta(Panel tarjeta, string usuarioId)
        {
            InfoUser usuarioActualizado = UsuarioManager.LeerUsuarios()
                .FirstOrDefault(u => u.id == usuarioId);

            if (usuarioActualizado == null) return;

            TableLayoutPanel layout = tarjeta.Controls.OfType<TableLayoutPanel>().FirstOrDefault();

            if (layout != null)
            {

                Label lblNombre = layout.GetControlFromPosition(0, 1) as Label;
                if (lblNombre != null)
                    lblNombre.Text = usuarioActualizado.username;

                Label lblEmail = layout.GetControlFromPosition(0, 2) as Label;
                if (lblEmail != null)
                    lblEmail.Text = usuarioActualizado.email;

                Label lblRol = layout.GetControlFromPosition(0, 3) as Label;
                if (lblRol != null)
                    lblRol.Text = $"Role: {usuarioActualizado.role}";
            }
        }

        private void ConfigurarMenu()
        {
            string NombreUsuario = "Tu Nombre";
            string CorreoUsuario = "tu@correo.com";

            if (SesionActual.HaySesionActiva())
            {
                NombreUsuario = SesionActual.UsuarioActual.username;
                CorreoUsuario = SesionActual.UsuarioActual.email;
            }

            menu = new MenuLateral(this, NombreUsuario, CorreoUsuario);

            menu.ColorFondo = Color.FromArgb(211, 145, 109);
            menu.ColorTexto = Color.FromArgb(61, 23, 0);
            menu.ColorHover = Color.FromArgb(190, 125, 90);

            menu.AgregarOpcion("🏠", "Home", () => IrAInicio());
            menu.AgregarOpcion("👥", "Usuarios", () => IrAUsuarios());
            menu.AgregarOpcion("🚪", "Cerrar Sesión", () => CerrarSesion());

            btnMenu.Text = "☰";
            btnMenu.Size = new Size(50, 1200);
            btnMenu.Location = new Point(0, 40);
            btnMenu.Font = Fuentes.RubikBold(40);
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.BackColor = Color.FromArgb(228, 235, 241);
            btnMenu.ForeColor = Color.FromArgb(252, 250, 249);
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.Click += (s, e) => menu.Toggle();
            this.Controls.Add(btnMenu);
            btnMenu.BringToFront();
        }

        private void IrAInicio()
        {
            Home home = new Home();
            home.ShowDialog();
        }

        private void IrAUsuarios()
        {
            Users users = new Users();
            users.ShowDialog();
        }

        private void CerrarSesion()
        {
            DialogResult resultado = MessageBox.Show(
                "¿Seguro que quieres cerrar sesión?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Panel panelformulario = new Panel();
            panelformulario.Size = new Size(600, 700);
            panelformulario.BackColor = Color.FromArgb(228, 235, 241);
            panelformulario.Location = new Point(
                (this.ClientSize.Width - panelformulario.Width) / 2,
                (this.ClientSize.Height - panelformulario.Height) / 2);


            Label lblTitulo = new Label();
            lblTitulo.Text = "Please fill in all the information";
            lblTitulo.Font = Fuentes.RubikMedium(20);
            lblTitulo.ForeColor = Color.FromArgb(92, 135, 153);
            lblTitulo.AutoSize = true;
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panelformulario.Controls.Add(lblTitulo);

            lblTitulo.Left = (panelformulario.Width - lblTitulo.Width) / 2;
            lblTitulo.Top = 40;

            string[] labels = { "Fist Name", "Last Name", "Email", "Password", "Confirm Password" };

            TextBox[] textBoxes = new TextBox[5];
            int espacio = 120;


            for (int i = 0; i < labels.Length; i++)
            {

                Label lbl = new Label();
                lbl.Text = labels[i];
                lbl.Location = new Point(90, espacio);
                lbl.AutoSize = true;
                lbl.Font = Fuentes.RubikRegular(10);
                lbl.ForeColor = Color.FromArgb(92, 135, 153);
                panelformulario.Controls.Add(lbl);


                TextBox txt = new TextBox();
                txt.Location = new Point(90, espacio + 30);
                txt.Width = 410;
                txt.Height = 40;
                txt.Font = Fuentes.RubikRegular(15);
                txt.ForeColor = Color.FromArgb(61, 23, 0);
                txt.BorderStyle = BorderStyle.None;


                // Si es contraseña, ocultar caracteres
                if (i == 3 || i == 4)
                {
                    txt.PasswordChar = '*';
                }

                textBoxes[i] = txt;

                panelformulario.Controls.Add(txt);

                espacio += 70;
            }

            ComboBox combobox = new ComboBox();


            Button btnAdd = new Button();
            btnAdd.Text = "Añadir Usuario";
            btnAdd.Location = new Point(150, espacio + 50);
            btnAdd.Width = 250;
            btnAdd.Height = 50;
            btnAdd.BackColor = Color.FromArgb(204, 163, 193);
            btnAdd.Font = Fuentes.RubikRegular(15);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.FromArgb(252, 250, 249);

            btnAdd.Click += (s, args) =>
            {
                String firstName = textBoxes[0].Text;
                String lastName = textBoxes[1].Text;
                String email = textBoxes[2].Text;
                String password = textBoxes[3].Text;
                String confirmPassword = textBoxes[4].Text;

                if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(email)
                || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
                {
                    MessageBox.Show("Please complete all the fields.", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match", "Password error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string fullName = $"{firstName} {lastName}";

                InfoUser nuevoUsuario = UsuarioManager.RegistrarUsuario(fullName, password, email, "Developer");

                if (nuevoUsuario != null)
                {
                    CrearTarjetaUsuario(nuevoUsuario);
                    panelformulario.Visible = false;
                    MessageBox.Show($"User:{fullName} added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The email is already used", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            panelformulario.Controls.Add(btnAdd);
            this.Controls.Add(panelformulario);

            Button btnCancelar = new Button();
            btnCancelar.Text = "Cancelar";
            btnCancelar.Location = new Point(150, espacio + 120);
            btnCancelar.Width = 250;
            btnCancelar.Height = 50;
            btnCancelar.BackColor = Color.FromArgb(229, 122, 122);
            btnCancelar.Font = Fuentes.RubikRegular(15);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.FromArgb(252, 250, 249);

            btnCancelar.Click += (s, args) =>
            {
                panelformulario.Visible = false;
                panelformulario.Dispose();
                this.Controls.Remove(panelformulario);
            };

            panelformulario.Controls.Add(btnCancelar);
            this.Controls.Add(panelformulario);
            panelformulario.BringToFront();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string textoBusqueda = textBoxBuscar.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(textoBusqueda))
            {
                panelTarjetas.Controls.Clear();
                CargarTarjetasExistentes();
                return;
            }

            List<InfoUser> usuariosFiltrados = UsuarioManager.LeerUsuarios().Where(
                u => u.username.ToLower().Contains(textoBusqueda) || u.email.ToLower().Contains(textoBusqueda)
                || u.role.ToLower().Contains(textoBusqueda)).ToList();


            MostrarUsuariosFiltrados(usuariosFiltrados);

        }

        private void MostrarUsuariosFiltrados(List<InfoUser> usuarios)
        {
            panelTarjetas.Controls.Clear();

            if (usuarios.Count == 0)
            {
                Label lblNoEncontrado = new Label();
                lblNoEncontrado.Text = "No users found";
                lblNoEncontrado.Font = Fuentes.RubikMedium(18);
                lblNoEncontrado.ForeColor = Color.Gray;
                lblNoEncontrado.AutoSize = true;
                lblNoEncontrado.Margin = new Padding(300, 100, 0, 0);
                panelTarjetas.Controls.Add(lblNoEncontrado);
            }
            else
            {
                foreach (var usuario in usuarios)
                {
                    CrearTarjetaUsuario(usuario);
                }
            }
        }

        private void ConfigurarComboBoxFiltros()
        {
            comboBoxFiltro.Items.Clear();
            comboBoxFiltro.Items.AddRange(new object[]
            {
                "Name (A-Z)",
                "Name (Z-A)",
                "Role (Manager first)",
                "Role (Developer first)",
                "Email (A-Z)"
            }
            );
            comboBoxFiltro.SelectedIndex = 0;

            comboBoxFiltro.SelectedIndexChanged += comboBoxFiltro_SelectedIndexChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<InfoUser> usuarios = UsuarioManager.LeerUsuarios();

            switch (comboBoxFiltro.SelectedIndex)
            {
                case 0:
                    usuarios = usuarios.OrderBy(u => u.username).ToList();
                    break;
                case 1:
                    usuarios = usuarios.OrderByDescending(u => u.username).ToList();
                    break;
                case 2:
                    usuarios = usuarios.OrderBy(u => u.role == "Manager" ? 0 : 1).
                        ThenBy(u => u.username).ToList();
                    break;
                case 3:
                    usuarios = usuarios.OrderBy(u => u.role == "Developer" ? 0 : 1).
                        ThenBy(u =>u.username).ToList();
                    break;
                case 4:
                    usuarios = usuarios.OrderBy(u => u.email).ToList();
                    break;
            }

            MostrarUsuariosFiltrados(usuarios);

        }
    }
}
    

