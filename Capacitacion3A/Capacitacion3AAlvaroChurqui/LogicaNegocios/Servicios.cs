using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccesoDatos;
using Entidades;
using System.Data;
using System.Security.Cryptography;

namespace LogicaNegocios
{
    public class Servicios
    {
        public Servicios() { }
        #region Mètodos y estructuras privadas
        private static string GetSHA256(string x)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] s = null;
            StringBuilder sb = new StringBuilder();
            s = sha256.ComputeHash(encoding.GetBytes(x));
            for (int i = 0; i < s.Length; i++)
                sb.AppendFormat("{0:x2}",s[i]);
            return sb.ToString();
        }
        private Dictionary<string, byte> diCargo = new Dictionary<string, byte>
         {
             {"Sistemas",0 },
             {"Rector",1 },
             {"Dir. Academico",2 },
             {"Dir. Administrativo",3 },
             {"Secretaria",4 },
             {"Auxiliar",5 },
             {"Docente",6 },
         };

        private string generarUsuario(Persona P)
        {
            string aux = "";
            if (P.paterno == "")
                aux = P.materno.Substring(0, 1);
            else if(P.materno == "")
                aux = P.paterno.Substring(0, 1);
            else
                aux = P.paterno.Substring(0, 1) + P.materno.Substring(0, 1);

            string nombreUsuario = aux +
                P.nombres.Substring(0,1)+"-"+ P.fechaNacimiento.ToString().Substring(0, 2) + P.fechaNacimiento.ToString().Substring(3,2)+P.fechaNacimiento.ToString().Substring(8,2);
            return nombreUsuario;
        }

        private bool validarRegistroUsuario(Persona P)
        {
            if (P.ci >= 100000 && P.ci <= 19999999 && P.nombres != "" && (P.paterno != "" || P.materno != "") && P.celular >= 60000000 && P.celular <= 79999999 && P.ultimoUsuario > 0)
                return true;
            else
                return false;
        }
        

        #endregion

        #region Mètodos publicos LISTAR

        //Mostrar administrativos
        public DataTable mostrarAdministrativos()
        {
            Manager objM = new Manager();
            return objM.listarAdministrativos();
        }

        public List<string> listaCargos()
        {
            List<string> lista = new List<string>();
            foreach (string key in diCargo.Keys)
                lista.Add(key.ToString());

            lista.Reverse();
            return lista;
        }
        public int login(string usuario, string password)
        {
            if (usuario != "" && password != "")
            {
                Manager objManager = new Manager();
                password = GetSHA256(password);
                int? ci = objManager.obtieneCiUsuario(usuario, password);
                if (ci == null)
                    throw new Exception("Usuario no Registrado en la BD");
                else
                    return Convert.ToInt32(ci);

            }
            else
            {
                throw new Exception("Ingrese datos válidos!!!");
            }
        }
        //NOMBRE COMPLETO
        public string mostrarNombreCompletoUsuario(int ci)
        {
            Manager objManager = new Manager();
            return objManager.obtieneNombreCompleto(ci);
        }

        //NIVEL DE ACCESO
        public short mostrarNivelUsuario(int ci)
        {
            Manager objManager = new Manager();
            return objManager.obtieneNivelUsuario(ci);
        }

        //CARGO 
        public string mostrarCargoUsuario(int nivel)
        {
            foreach (string cargo in diCargo.Keys)
                if (diCargo[cargo] == nivel)
                    return cargo.ToString();
            return null;
        }
        //CI y Nombre completo del DOCENTE
        public DataTable mostrarCiNombreCompletoDocente(string x)
        {
            Manager objManager = new Manager();
            return objManager.obtieneCiNombreCompletoDocente(x);
        }
        //Mostrar Cursos
        public DataTable mostrarCursos(bool A)
        {
            Manager objManager = new Manager();
            string X;
            if (A)
                X = "fechaCreacion";
            else
                X = "fechaInicio";
            return objManager.obtieneCursos(X); 
        }

        //Mostrar los cursos disponibels iniciados hace 2 semanas

        public DataTable mostrarCursosDisponibles()
        {
            Manager objManager = new Manager();
            return objManager.obtieneCursosDisponibles();
        }

        //Mostrar los cursos disponibels iniciados hace 2 semanas

        public DataTable mostrarCurso()
        {
            Manager objManager = new Manager();
            return objManager.obtenerCursosDisponibles();
        }

        public int? mostrarCosto(string X)
        {
            if (!String.IsNullOrEmpty(X))
            {
                Manager objManager = new Manager();
                return objManager.obtieneCosto(X);
            }
            else
                return null;
        }
        // mostrar ESTUDIANTE ANTIGUO
        public DataTable mostrarEstudiante(int ci)
        {
            Manager objManager = new Manager();
            return objManager.obtieneEstudiante(ci);
        }
        //Mostrar cursos
        public DataTable mostrarCursos()
        {
            Manager objManager = new Manager();
            return objManager.obtieneCursos();
        }
       //Mostrar Lista Inscritos
        public DataTable mostrarListaInscritos(short sw, string dato)
        {
            Manager objManager = new Manager();
            switch (sw)
            {
                case 1:
                    // Lista por curso
                    return objManager.obtieneInscritosPorCurso(dato);
                case 2:
                    // Lista por genero
                    return objManager.obtieneInscritosPorCurso(dato);
                case 3:
                    // Lista por fecha
                    return objManager.obtieneInscritosPorCurso(dato);
                case 4:
                    // Lista por pago
                    return objManager.obtieneInscritosPorCurso(dato);
                case 5:
                    // Lista por tipo de curso
                    return objManager.obtieneInscritosPorCurso(dato);
                default:
                    return null;
            }
           
        }
        #endregion

        #region Mètodos AGREGAR
        // Agregar Aministrativo
        public bool agregarAdministrativo(Administrativo A)
        {
            // desglozar el objeto A en una persona P
            Persona P = new Persona();
            P.ci = A.ci;
            P.paterno = A.paterno.ToLower();
            P.materno = A.materno.ToLower();
            P.nombres = A.nombres.ToLower();
            P.direccion = A.direccion.ToLower();
            P.celular = A.celular;
            P.profesion = A.profesion.ToLower();
            P.fechaNacimiento = A.fechaNacimiento;
            P.ultimoUsuario = A.ultimoUsuario;

            if (validarRegistroUsuario(P))
            {
                //encriptar la contraseña
                A.contrasena = GetSHA256(A.ci.ToString());
                A.usuario = generarUsuario(P).ToLower();
                A.nivel = diCargo[A.cargo];
                //A.cargo = A.cargo.ToLower();

                Manager objManager = new Manager();


                if (objManager.insertarPersona(P))
                    if (A.nivel == 6)
                    {
                        Docente D = new Docente();
                        D.ciDocente = A.ci;
                        D.usuario = A.usuario;
                        D.contrasena = A.contrasena;
                        if (objManager.insertarDocente(D))
                            return true;
                        else throw new Exception("ERROR al insertar Docente");
                    } 
                    else if (objManager.insertarAdministrativo(A))
                        return true;
                    else throw new Exception("ERROR al insertar Administrativo");
                else throw new Exception("ERROR al insertar Persona");
            } 
            else throw new Exception("ERROR inserte valores reales y correctos");
        }
        //Agregar Curso
        public bool agregarCurso(Curso c)
        {
            if (c.nombre.Trim().Length >= 10)
                if (c.horario.Trim().Length >= 10)
                    if (c.ciDocente > 0)
                    {
                        Manager objManager = new Manager();
                        if (objManager.insertarCurso(c))
                            return true;
                        else throw new Exception("Error al registar el curso en la Base de Datos.");
                    }
                    else throw new Exception("Seleccione el docente que dictara el curso.");
                else throw new Exception("Ingrese un horario con mas de 10 caracteres.");
            else throw new Exception("Ingrese un nombre de curso válido que tenga más de 10 caracteres.");

        }
        //Agregar inscripcion 
        public bool agregarInscripcion(Inscripcion i)
        {
            Manager objManager = new Manager();
            if (objManager.obtieneCantidadInscripcion(i) == 0)
            {
                if (i.ciEstudiante > 0) 
                    if (i.idCurso > 0)
                    {
                 
                        if (objManager.insertarIncripcion(i))
                            return true;
                            else throw new Exception("Error al registar LA INSCRIPCION en la Base de Datos.");
                    }
                    else throw new Exception("Seleccionar un CURSO.");
                 else throw new Exception("Ingrese un CI de estudiante valido.");
            }
            else throw new Exception("ERROR: el estudiante y esta inscrito en el curso!! \n Se inscribio en fecha: "+objManager.obtieneFechaInscripcion(i));
        }
        //Agragar Inscripcion de estudiantes NUEVOS
        public bool agregarInscripcion(Inscripcion i, Estudiante e)
        {
            Manager objManager = new Manager();
            if (objManager.obtieneCantidadInscripcion(i) == 0)
            {
                if (i.ciEstudiante > 0)
                    if (i.idCurso > 0)
                    {
                        Persona P = new Persona();
                        P.ci = e.ci;
                        P.paterno = e.paterno.ToLower();
                        P.materno = e.materno.ToLower();
                        P.nombres = e.nombres.ToLower();
                        P.direccion = e.direccion.ToLower();
                        P.celular = e.celular;
                        P.profesion = e.profesion.ToLower();
                        P.fechaNacimiento = e.fechaNacimiento;
                        P.ultimoUsuario = e.ultimoUsuario;
                        if (validarRegistroUsuario(P))
                        {

                            if (objManager.insertarPersona(P))
                                if (objManager.insertarEstudiante(e))
                                    if (objManager.insertarIncripcion(i))
                                        return true;
                                    else throw new Exception("ERROR al registrar la INSCRIPCION");
                                else throw new Exception("ERROR al registrar ESTUDIANTE.");
                            else throw new Exception("ERROR al registrar los DATOS PERSONALES.");
                        }
                        else throw new Exception("ERROR inserte valores reales y correctos");
                    }
                    else throw new Exception("ERROR Seleccione un curso");
                else throw new Exception("ERROR ingrese los datos de un estudiante");
            }
            else throw new Exception("ERROR: el estudiante y esta inscrito en el curso");
        }

            #endregion
        }
}
