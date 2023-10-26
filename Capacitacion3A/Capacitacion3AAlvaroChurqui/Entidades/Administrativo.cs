using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrativo:Persona
    {
        public Administrativo() { }
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public string cargo { get; set; }
        public short nivel { get; set; }
        
    }
}
