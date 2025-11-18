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
        private static string rutaArchivo = Path.Combine(Application.StartupPath, "Json", "Usuarios.json");


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
            } catch
            {
                return new List<InfoUser>();
            }
        }
        
        
        private static void GuardarUsuarios(List<InfoUser>usuarios)
        {
            // Obtener la carpeta donde está el archivo
            string directorio = Path.GetDirectoryName(rutaArchivo);

            // Crear la carpeta si no existe
            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }

            string json = JsonConvert.SerializeObject(usuarios, Formatting.Indented);
            File.WriteAllText(rutaArchivo, json);

        }


        public static bool RegistrarUsuario(string nombre, string contraseña, string email, string rol)
        {
            try
            {
                List<InfoUser> usuarios = LeerUsuarios();

                if (usuarios.Any(u => u.email.ToLower() == email.ToLower()))
                {
                    return false;
                }

                InfoUser nuevoUsuario = new InfoUser(nombre, contraseña, email, rol);

                usuarios.Add(nuevoUsuario);
                GuardarUsuarios(usuarios);

                return true;
            }
            catch (Exception ex)
            {
                // Ver el error real
                MessageBox.Show($"Error: {ex.Message}", "Error al registrar");
                return false;
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
