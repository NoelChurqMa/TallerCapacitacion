using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Inscripcion
    {
        public Inscripcion() { }
        public int idInscripcion { get; set; }
        public DateTime fechaHora { get; set; }
        public int ciEstudiante { get; set; }
        public int ciAdministrativo { get; set; }
        public int idCurso { get; set; }
        public short pago { get; set; }
        public bool estado { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaModificacion { get; set; }
        public int ultimoUsuario { get; set; }
    }
}
