using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Docente: Persona
    {
        public Docente() { }
        public int ciDocente { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public short nivel { get; set; }

    }
}
