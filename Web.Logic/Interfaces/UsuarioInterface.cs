using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Logic.Interfaces
{
    public class UsuarioInterface
    {
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Perfil { get; set; }
        public bool? Estado { get; set; }
        public string UsuarioIngresa { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string UsuarioModifica { get; set; }
        public DateTime? FechaModificacion { get; set; }

    }
}
