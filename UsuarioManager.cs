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
                MessageBox.Show($"Error al crear la carpeta de datos: {ex.Message}", "Error Fatal");
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
                MessageBox.Show($"Error al leer usuarios: {ex.Message} en la ruta: {rutaArchivo}", "Error de Lectura JSON");
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
                MessageBox.Show($"Error al guardar usuarios: {ex.Message} en la ruta: {rutaArchivo}", "Error de Escritura JSON");
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
                MessageBox.Show($"Error: {ex.Message}", "Error al registrar");
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
                    return "El archivo no existe.";

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
                return $"Error al leer el archivo: {ex.Message}";
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
                    MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (usuarioAEliminar.role.ToLower() == "manager")
                {
                    int cantidadManager = usuarios.Count(u => u.role.ToLower() == "manager");
                    if (cantidadManager <= 1)
                    {
                        MessageBox.Show("No puedes eliminar al único Manager del sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;

                    }
                }

                usuarios.Remove(usuarioAEliminar);

                GuardarUsuarios(usuarios);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (usuarioAEditar.email != nuevoEmail)
                {
                    if (usuarios.Any(u => u.email.ToLower() == nuevoEmail.ToLower() && u.id != id))
                    {
                        MessageBox.Show("El email ya está en uso por otro usuario.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"Error al editar usuario: {ex.Message}", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }

}
