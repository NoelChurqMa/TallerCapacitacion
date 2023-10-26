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
    public partial class FormCursos : Form
    {
        public FormCursos()
        {
            InitializeComponent();
        }

        private void btnNuevoDocente_Click(object sender, EventArgs e)
        {
            FormAdministrativos f = new FormAdministrativos();
            f.ShowDialog();
        }

        private void txtDocente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDocente.Text.Trim() != "")
                {
                    Servicios objServicios = new Servicios();
                    dataDocentes.DataSource = objServicios.mostrarCiNombreCompletoDocente(txtDocente.Text.ToLower());
                    dataDocentes.Refresh();
                    dataDocentes.Visible = true;
                }
                else
                    dataDocentes.Visible = false;
            }
            catch
            {
                dataDocentes.Visible = false;
            }
        }
        int ciDocente = 0;

        private void dataDocentes_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ciDocente = (int)dataDocentes.SelectedRows[0].Cells[0].Value;
                txtDocente.Text = dataDocentes.SelectedRows[0].Cells[1].Value.ToString().ToUpper();
                dataDocentes.Visible = false;
            }
            catch
            {

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Curso objCurso = new Curso();
                objCurso.nombre = txtNombre.Text.Trim().ToLower();
                objCurso.tipo = cmbTipo.Text.ToLower();
                objCurso.cargaHoraria = (int)(numCargaHoraria.Value);
                objCurso.descripcion = txtDescripcion.Text.ToLower().Trim();
                objCurso.horario = txtHorario.Text.ToLower().Trim();
                objCurso.costo = (int)numCosto.Value;
                objCurso.ciDocente = ciDocente;
                objCurso.ultimoUsuario = Program.clave;
                objCurso.fechaInicio = dateFechaInicio.Value;

                Servicios objServicios = new Servicios();
                if (objServicios.agregarCurso(objCurso))
                {
                    MessageBox.Show("Registro de curso exitoso.", "Confirmación", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    btnGuardar.Enabled = false;
                    dataCursos.DataSource = null;
                    dataCursos.DataSource = objServicios.mostrarCursos(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Mensaje de error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void FormCursos_Load(object sender, EventArgs e)
        {
            Servicios objServicios = new Servicios();
            dataCursos.DataSource = objServicios.mostrarCursosDisponibles();
            lblUsuario.Text = "Usuario : " + objServicios.mostrarNombreCompletoUsuario(Program.clave).ToUpper();
            lblCargo.Text = "Cargo : " + objServicios.mostrarCargoUsuario(objServicios.mostrarNivelUsuario(Program.clave));

            //controlar FECHA DE INICIO
            dateFechaInicio.MinDate = DateTime.Now;
            dateFechaInicio.MaxDate = DateTime.Now.AddMonths(3);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Clear();
            txtNombre.Clear();
            txtHorario.Clear();
            txtDocente.Clear();
            numCargaHoraria.Value = 20;
            numCosto.Value = 0;
            btnGuardar.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioFechaInicico_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFechaInicico.Checked)
            {
                Servicios objServicios = new Servicios();
                dataCursos.DataSource = null;
                dataCursos.DataSource = objServicios.mostrarCursos(false);
            }
        }

        private void radioTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTodos.Checked)
            {
                Servicios objServicios = new Servicios();
                dataCursos.DataSource = null;
                dataCursos.DataSource = objServicios.mostrarCursos(true);
            }
        }

        private void radioDisponibles_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDisponibles.Checked)
            {
                Servicios objServicios = new Servicios();
                dataCursos.DataSource = null;
                dataCursos.DataSource = objServicios.mostrarCursosDisponibles();
            }
        }
    }
    }
