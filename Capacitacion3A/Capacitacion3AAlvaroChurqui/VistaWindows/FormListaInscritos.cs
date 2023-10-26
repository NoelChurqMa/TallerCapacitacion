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
using Entidades;

namespace VistaWindows
{
    public partial class FormListaInscritos : Form
    {
        public FormListaInscritos()
        {
            InitializeComponent();
        }

        private void cmbTipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBoxPorCurso.Visible = false;
            if (cmbTipoReporte.Text == "Por CURSO")
            {
                groupBoxPorCurso.Visible = true;
            }
        }

        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            Servicios objServicios = new Servicios();

        }

        private void FormListaInscritos_Load(object sender, EventArgs e)
        {
            Servicios objServicios = new Servicios();

            cmbCurso.DataSource = objServicios.mostrarCursos();
            cmbCurso.DisplayMember = "Nombre";
        }
    }
}
