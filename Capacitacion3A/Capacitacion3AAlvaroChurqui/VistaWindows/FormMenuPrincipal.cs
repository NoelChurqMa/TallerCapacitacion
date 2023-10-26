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
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            Servicios objServicios = new Servicios();
            lblUsuario.Text = "Usuario : " + objServicios.mostrarNombreCompletoUsuario(Program.clave).ToUpper();
            lblCargo.Text = "Cargo : " + objServicios.mostrarCargoUsuario(objServicios.mostrarNivelUsuario(Program.clave));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAdministrativos f = new FormAdministrativos();
            f.ShowDialog();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            FormCursos f = new FormCursos();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormInscripcion f = new FormInscripcion();
            f.ShowDialog();
        }
    }
}
