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
            // 1. Obtener la ruta base de AppData Roaming
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            // 2. Definir la carpeta específica de la aplicación
            const string nombreCarpetaApp = "KalendulaData";

            // 3. Combinar la ruta base con el nombre de la carpeta
            folderPath = Path.Combine(appData, nombreCarpetaApp);

            // 4. Definir la ruta completa del archivo JSON
            rutaArchivo = Path.Combine(folderPath, "Usuarios.json");

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

            return usuarios.Any(u => u.role.ToLower() == "anager");

        }

        public static List<InfoUser> LeerUsuarios()
        {
            try
            {
                string json = File.ReadAllText(rutaArchivo);
                List<InfoUser> usuarios = JsonConvert.DeserializeObject<List<InfoUser>>(json);

                return usuarios ?? new List<InfoUser>();
            } catch
            {
                return new List<InfoUser>();
            }
        }
        
        
        private static void GuardarUsuarios(List<InfoUser>usuarios)
        {
            string json = JsonConvert.SerializeObject(usuarios, Formatting.Indented);
            File.WriteAllText(rutaArchivo, json);

        }


        public static InfoUser RegistrarUsuario(string nombre, string contraseña, string email, string rol)
        {
            try
            {
                List<InfoUser> usuarios = LeerUsuarios();

                string rolFinal;
                if(usuarios.Count == 0)
                {
                    rolFinal = "Manager";
                } 
                else if (usuarios.Any(u => u.email.ToLower() == email.ToLower()))
                {
                    return null;
                } 
                else
                {
                    rolFinal = "Desarrollador";
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
    }
}
