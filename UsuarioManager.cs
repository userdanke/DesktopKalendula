using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopKalendula
{
    public static class UsuarioManager
    {
        private static readonly string folderPath;
        private static readonly string rutaArchivo;

        static UsuarioManager()
        {
            rutaArchivo = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\Json\users.json"));
            folderPath = Path.GetDirectoryName(rutaArchivo);

            // 5. Crear la carpeta si no existe
            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
            }
            catch (Exception ex)
            {
                // Manejar errores si no se puede crear la carpeta (ej. permisos)
                MessageBox.Show($"Error creating data folder: {ex.Message}", "Fatal Error");
            }
        }


        public static bool ExistenUsuarios()
        {
            return File.Exists(rutaArchivo);
        }


        public static bool ExisteMananger()
        {
            if (!ExistenUsuarios())
                return false;

            List<InfoUser> usuarios = LeerUsuarios();

            return usuarios.Any(u => u.role.ToLower() == "manager");

        }

        public static List<InfoUser> LeerUsuarios()
        {
            try
            {
                string json = File.ReadAllText(rutaArchivo);
                List<InfoUser> usuarios = JsonConvert.DeserializeObject<List<InfoUser>>(json);

                return usuarios ?? new List<InfoUser>();
            } catch (Exception ex)
            {
                MessageBox.Show($"Error reading users: {ex.Message} on the route: {rutaArchivo}", "JSON Read Error");
                return new List<InfoUser>();
            }
        }


        public static void GuardarUsuarios(List<InfoUser> usuarios)
        {
            try
            {
                string json = JsonConvert.SerializeObject(usuarios, Formatting.Indented);
                File.WriteAllText(rutaArchivo, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving users: {ex.Message} in the path: {rutaArchivo}", "JSON Write Error");
            }

        }


        public static InfoUser RegistrarUsuario(string nombre, string contraseña, string email, string rol)
        {
            try
            {
                List<InfoUser> usuarios = LeerUsuarios();

                string rolFinal;
                if (usuarios.Count == 0)
                {
                    rolFinal = "Manager";
                }
                else if (usuarios.Any(u => u.email.ToLower() == email.ToLower()))
                {
                    return null;
                }
                else
                {
                    rolFinal = "Developer";
                }

                InfoUser nuevoUsuario = new InfoUser(nombre, contraseña, email, rolFinal);

                usuarios.Add(nuevoUsuario);
                GuardarUsuarios(usuarios);

                return nuevoUsuario;
            }
            catch (Exception ex)
            {
                // Ver el error real
                MessageBox.Show($"Error: {ex.Message}", "Error registering");
                return null;
            }
        }


        public static InfoUser ValidarLogin(string email, string contraseña)
        {
            List<InfoUser> usuarios = LeerUsuarios();

            return usuarios.FirstOrDefault(u => u.email.ToLower() == email.ToLower() &&
            u.password == contraseña);
        }

        public static string LeerContenido(string nombreArchivo)
        {
            try
            {
                string rutaCompleta = rutaArchivo;

                if (!File.Exists(rutaCompleta))
                    return "The file does not exist.";

                string json = File.ReadAllText(rutaCompleta);

                // Si el archivo está vacío
                if (string.IsNullOrWhiteSpace(json))
                    return "[]";

                // Formatear el JSON para que se vea bonito
                dynamic obj = JsonConvert.DeserializeObject(json);
                return JsonConvert.SerializeObject(obj, Formatting.Indented);
            }
            catch (Exception ex)
            {
                return $"Error reading the file: {ex.Message}";
            }
        }

        public static bool EliminarUsuario(string id)
        {
            try
            {
                List<InfoUser> usuarios = LeerUsuarios();

                InfoUser usuarioAEliminar = usuarios.FirstOrDefault(u => u.id == id);

                if (usuarioAEliminar == null)
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (usuarioAEliminar.role.ToLower() == "manager")
                {
                    int cantidadManager = usuarios.Count(u => u.role.ToLower() == "manager");
                    if (cantidadManager <= 1)
                    {
                        MessageBox.Show("You cannot delete the only Manager in the system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;

                    }
                }

                usuarios.Remove(usuarioAEliminar);

                GuardarUsuarios(usuarios);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool EditarUsuario(string id, string nuevoNombre, string nuevoEmail, string nuevaContraseña, string nuevoRol)
        {
            try
            {
                List<InfoUser> usuarios = LeerUsuarios();
                InfoUser usuarioAEditar = usuarios.FirstOrDefault(u => u.id == id);

                if (usuarioAEditar == null)
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (usuarioAEditar.email != nuevoEmail)
                {
                    if (usuarios.Any(u => u.email.ToLower() == nuevoEmail.ToLower() && u.id != id))
                    {
                        MessageBox.Show("This email address is already in use by another user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                usuarioAEditar.username = nuevoNombre;
                usuarioAEditar.email = nuevoEmail;


                if (!string.IsNullOrWhiteSpace(nuevaContraseña))
                {
                    usuarioAEditar.password = nuevaContraseña;
                }

                if (!string.IsNullOrWhiteSpace(nuevoRol))
                {
                    usuarioAEditar.role = nuevoRol;
                }

                GuardarUsuarios(usuarios);

                return true;
            }

            catch (Exception ex) {
                MessageBox.Show($"Error editing user: {ex.Message}", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }

}
