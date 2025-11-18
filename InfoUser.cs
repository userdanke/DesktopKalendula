using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopKalendula
{
    public class InfoUser
    {
        public string id { get; set; }
        public string role { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }

        public InfoUser() { }

        public InfoUser(string nombre, string contraseña, string correo, string rol)
        {
            this.id = Guid.NewGuid().ToString();
            this.username = nombre;
            this.password = contraseña;
            this.email = correo;
            this.role = rol;

        }
    }
}
