using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        public Persona() { }
        public int ci { get; set; }
        public string paterno { get; set; }
        public string materno { get; set; }
        public string nombres { get; set; }
        public int celular { get; set; }
        public string direccion { get; set; }
        public string profesion { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public bool estado { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaModificacion { get; set; }
        public int ultimoUsuario { get; set; }
        public string genero { get; set; }
      
    }
}
