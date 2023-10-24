using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTOs
{
    public class UsuariosDto
    {
        public int Id { get; set; }
        public int Email { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public bool Activo { get; set; }

    }
}
