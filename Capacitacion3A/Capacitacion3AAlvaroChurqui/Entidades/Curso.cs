using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        public Curso() { }
        public int idCurso { get; set; }
        public string nombre { get; set; }
        public string tipo { get; set; }
        public int cargaHoraria { get; set; }
        public string descripcion { get; set; }
        public string horario { get; set; }
        public int costo { get; set; }
        public int ciDocente { get; set; }
        public bool estado { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaModificacion { get; set; }
        public int ultimoUsuario { get; set; }
        public DateTime fechaInicio { get; set; }

    }
}
