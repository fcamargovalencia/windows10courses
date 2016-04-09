using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesManagement.Models
{
    public class Rol
    {
        public string idRol { get; set; }
        public string nombreRol { get; set; }
    }

    public class Persona
    {
        public string idPersona { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public string identificacion { get; set; }
        public string celular { get; set; }
        public string fechaNacimiento { get; set; }
    }

    public class Usuario
    {
        public int idUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string password { get; set; }
        public string correo { get; set; }
        public Rol rol { get; set; }
        public Persona persona { get; set; }
    }

    public class ContractUsuarios
    {
        public List<Usuario> usuario { get; set; }
    }
}
