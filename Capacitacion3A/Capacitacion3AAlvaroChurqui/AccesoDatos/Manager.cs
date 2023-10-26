using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using System.Data;
using System.Data.SqlClient; //Para trabajar con SQLSERVER

namespace AccesoDatos
{
    public class Manager
    {
        public Manager() { }

        #region Metodos Privados

        //Cadena de conexion
        private SqlConnection conexion = new SqlConnection(@"Data Source=(local); Initial Catalog=Curso3A; Integrated Security=True");

        //Verificar la ejecucion de Registros, Actualizacion y Eliminacion
        private bool trabajoDDLyDML(string vMensaje)
        {
            try
            {
                SqlCommand sql = new SqlCommand(vMensaje, conexion);
                conexion.Open();
                sql.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (Exception)
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
                return false;
            }

        }

        //comprobar si se obtuvo un DATO de la BD, cuando se realiza la consulta
        //tipo OBJECT para recibir cualquier tipo de dato
        private object obtieneDato(string vMensaje)
        {
            try
            {
                conexion.Open();
                SqlCommand carta = new SqlCommand(vMensaje, conexion);
                object x = new object();
                x = carta.ExecuteScalar();
                conexion.Close();
                return x;
            }
            catch (Exception)
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
                return null;
            }
        }

        //comprobar si se obtuvo UNA LISTA de la BD
        //List<object> para cualquier tipo de dato
        private List<object> obtieneLista(string vMensaje)
        {
            try
            {
                conexion.Open();
                SqlCommand carta = new SqlCommand(vMensaje, conexion);
                SqlDataReader resultado = carta.ExecuteReader();
                List<object> lista = new List<object>();
                //resultado.Read es una funcion que ndevuelve TRUE mientras haya datos en una
                //devuelve FALSE cuando no hay mas terminos que leer de una lista

                while (resultado.Read())
                {
                    lista.Add(resultado[0]);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception)
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
                return null;
            }
        }
        //comprobar si se obtuvo en una tabla de la BD
        private DataTable obtieneTabla(string vMensaje)
        {
            try
            {
                SqlDataAdapter carta = new SqlDataAdapter(vMensaje, conexion);

                DataTable tabla = new DataTable();
                //FILL automaticamente abre y cierre la conexion con la BD y llena la t
                carta.Fill(tabla);
                return tabla;
             
            }
            catch (Exception)
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
                return null;
            }
        }

        #endregion
        #region Metodos PUBLICOS OBTENER DATOS, LISTAS O TABLA
        
        //Listar todos los administrativos
        public DataTable listarAdministrativos()
        {
            string vConsulta = "SELECT p.ci AS 'C.I.', UPPER(p.paterno) AS 'PATERNO', UPPER(p.materno) AS 'MATERNO', UPPER(p.nombres) AS 'NOMBRES', UPPER(p.celular) AS 'NUMERO', UPPER(a.cargo) AS 'CARGO' FROM Administrativo a, Persona p WHERE A.ciPersona = P.ci ORDER BY p.fechaCreacion DESC; ";
            return obtieneTabla(vConsulta);
        }

        //Obtener el CI de un ADMINISTRATIVO segun usuario y contraena
        public int? obtieneCiUsuario(string usu, string con)
        {
            string vConsulta = "SELECT ciPersona FROM Administrativo WHERE usuario LIKE '"+usu+"' AND contrasena LIKE '"+con+"' ";
            if (obtieneDato(vConsulta) == null)
                return null;
            else
                return Convert.ToInt32(obtieneDato(vConsulta));
        }
        
        //Obtener el NOMBRE COMPLETO según ci
        public string obtieneNombreCompleto(int ci)
        {
            string vConsulta = "SELECT CONCAT(nombres, ' ' , paterno, ' ' , materno) AS NombreCompleto FROM Persona WHERE ci = " + ci;
            return obtieneDato(vConsulta).ToString();
        }
        //Obtener NIVEL segun CI
        public short obtieneNivelUsuario(int ci)
        {
            string vConsulta = "SELECT nivel FROM Administrativo WHERE ciPersona = " + ci;
            return Convert.ToInt16(obtieneDato(vConsulta));
        }
        //Obtener el CI y NOMBRE COMPLETO de un DOCENTE  segun lo escrito
        public DataTable obtieneCiNombreCompletoDocente(string x)
        {
            string vConsulta = "SELECT p.ci, CONCAT(nombres, ' ', paterno, ' ', materno) AS 'Docente' FROM Persona p, docente d WHERE p.ci = d.ciPersona AND (p.nombres LIKE '%"+ x + "%' OR p.paterno LIKE '%" + x + "%' OR p.materno LIKE '%" + x + "%')";
            return obtieneTabla(vConsulta);
        }

        //Obtener todos los cursos
        public DataTable obtieneCursos(string X)
        {
            string vConsulta = "SELECT UPPER(c.nombre) AS 'Curso', UPPER(c.tipo) AS 'Tipo', c.fechaInicio AS 'Inicio',UPPER(CONCAT(p.nombres, ' ', p.paterno, ' ', p.materno)) AS 'Docente',c.costo AS 'Costo',c.cargaHoraria AS 'Horas',UPPER(c.horario) AS 'Horario' FROM Curso c INNER JOIN Persona p ON p.ci = c.ciDocente ORDER BY c."+ X +" DESC; ";
            return obtieneTabla(vConsulta);
        }

        //Obtener los ultimos cursos hace dos semanas
        public DataTable obtieneCursosDisponibles()
        {
            string vConsulta = "SELECT UPPER(c.nombre) AS 'Curso', UPPER(c.tipo) AS 'Tipo', c.fechaInicio AS 'Inicio', UPPER(CONCAT(p.nombres, ' ', p.paterno, ' ', p.materno)) AS 'Docente', c.costo AS 'Costo', c.cargaHoraria AS 'Horas', UPPER(c.horario) AS 'Horario' FROM Curso c INNER JOIN Persona p ON p.ci = c.ciDocente WHERE c.fechaInicio >= DATEADD(DAY, -14, GETDATE()) ORDER BY c.fechaInicio DESC; ";
            return obtieneTabla(vConsulta);
        }
        //Obtener cursos disponibles de hace 14 dias para la inscripcion
        public DataTable obtenerCursosDisponibles()
        {
            string vConsulta = "SELECT c.idCurso, UPPER(c.nombre) AS 'Nombre' FROM Curso c INNER JOIN Persona p ON p.ci = c.ciDocente WHERE c.fechaInicio >= DATEADD(DAY, -14, GETDATE()) ORDER BY c.fechaInicio DESC; ";
            return obtieneTabla(vConsulta);
        }

        //obtiene costo de un curso
        public int obtieneCosto(string X)
        {
            string vConsulta = "SELECT TOP(1)costo FROM Curso WHERE nombre = '"+ X +"' ";
            return Convert.ToInt32(obtieneDato(vConsulta));
        }
        // obtiene ESTUDIANTE ANTIGUO
        public DataTable obtieneEstudiante(int ci)
        {
            string vConsulta = "SELECT p.ci AS 'C.I', UPPER(p.paterno) AS 'Ap. Paterno', UPPER(p.materno) AS 'Ap. Materno', UPPER(p.nombres) AS 'Nombres' FROM Estudiante e INNER JOIN Persona p ON p.ci = e.ciPersona WHERE e.ciPersona LIKE '%"+ ci +"%'; ";
            return obtieneTabla(vConsulta);
        }
        //Obtener la cantidad de inscripcion de un estudiante x en un curso Y
        public int obtieneCantidadInscripcion(Inscripcion i)
        {
            string vConsulta = "SELECT COUNT(idInscripcion) FROM Inscripcion WHERE ciEstudiante = "+ i.ciEstudiante +" AND idCurso = " + i.idCurso;
            return Convert.ToInt32(obtieneDato(vConsulta));
        }
        //Obtener la fecha de inscripcion de un estudiante x a un curso y
        public DateTime obtieneFechaInscripcion(Inscripcion i)
        {
            string vConsulta = "SELECT TOP(1)fechaHora FROM Inscripcion WHERE ciEstudiante = "+ i.ciEstudiante +" AND idCurso = " + i.idCurso;
            return (DateTime)obtieneDato(vConsulta);
        }
        //Obtener todos los cursos
        public DataTable obtieneCursos()
        {
            string vConsulta = "SELECT UPPER(nombre) AS  'Nombre' FROM Curso ORDER BY nombre ASC; ";
            return obtieneTabla(vConsulta);
        }

        #endregion

        #region Metodos publicos INSERTAR REGISTROS 
        //insertar Persona
        public bool insertarPersona(Persona objAdm)
        {
            string vConsulta = "SET DATEFORMAT 'DMY'; INSERT INTO Persona VALUES (" + objAdm.ci + ",'" + objAdm.paterno + "','" + objAdm.materno + "','" + objAdm.nombres + "'," + objAdm.celular + ",'" + objAdm.direccion + "','" + objAdm.profesion + "','" + objAdm.fechaNacimiento + "',1,GETDATE(),GETDATE()," + objAdm.ultimoUsuario + ",'"+ objAdm.genero +"')";
            return trabajoDDLyDML(vConsulta);
        }
        //Insertar Administrativo.
        public bool insertarAdministrativo(Administrativo objAdm)
        {
            string vConsulta = "INSERT INTO Administrativo VALUES ("+ objAdm.ci +", '"+ objAdm.usuario +"', '"+ objAdm.contrasena +"', '"+ objAdm.cargo +"', "+ objAdm.nivel +")";
            return trabajoDDLyDML(vConsulta);
        }
        //Insertar Curso
        public bool insertarCurso(Curso c)
        {
            string vConsulta = "SET DATEFORMAT 'DMY'; INSERT INTO Curso (nombre,tipo,cargaHoraria,descripcion,horario,costo,ciDocente,estado,fechaCreacion,fechaModificacion,ultimoUsuario,fechaInicio) VALUES ('" + c.nombre + "','" + c.tipo + "'," + c.cargaHoraria + ",'" + c.descripcion + "','" + c.horario + "'," + c.costo + "," + c.ciDocente + ",1,GETDATE(),GETDATE()," + c.ultimoUsuario + ",'"+ c.fechaInicio +"')";
            return trabajoDDLyDML(vConsulta);
        }

        // Insertar DOCENTE
        public bool insertarDocente(Docente d)
        {
            string vConsulta = "INSERT INTO Docente VALUES ("+ d.ciDocente +", '"+ d.usuario +"', '"+ d.contrasena +"', 6)";
            return trabajoDDLyDML(vConsulta);
        }
        //INSERTAR CURSO
        public bool insertarIncripcion(Inscripcion i) {
            string vConsulta = "INSERT INTO Inscripcion VALUES(GETDATE(),"+i.pago +","+ i.ciEstudiante+","+i.ciAdministrativo+","+i.idCurso+",1,GETDATE(),GETDATE(),"+ i.ultimoUsuario +");";
            return trabajoDDLyDML(vConsulta);
        }

        //Insertar  Estudiante
        public bool insertarEstudiante(Estudiante e) {
            string vConsulta = "INSERT INTO Estudiante VALUES("+ e.ci +")";
            return trabajoDDLyDML(vConsulta);
        }
        #endregion

        #region 
        #endregion
    }
}
