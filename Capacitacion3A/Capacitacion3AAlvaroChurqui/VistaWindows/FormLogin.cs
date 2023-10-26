using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LogicaNegocios;

namespace VistaWindows
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Servicios objServicios = new Servicios();
            try
            {
                //Almacenar en la variable global el ci de usuario
                Program.clave = objServicios.login(txtUsuario.Text, txtContrasena.Text);
                string NC = objServicios.mostrarNombreCompletoUsuario(Program.clave);
                string C = objServicios.mostrarCargoUsuario(objServicios.mostrarNivelUsuario(Program.clave));
                MessageBox.Show("Bienvenido al Sistema:\n\n"+"Usuario:\t"+NC.ToUpper()+"\nCargo:\t"+C.ToUpper(),"Acceso Correcto",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtUsuario.Clear();
                txtContrasena.Clear();
                //FormAdministrativos f = new FormAdministrativos();
                FormMenuPrincipal f = new FormMenuPrincipal();
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                //El error viene desde la logica de negocio
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
