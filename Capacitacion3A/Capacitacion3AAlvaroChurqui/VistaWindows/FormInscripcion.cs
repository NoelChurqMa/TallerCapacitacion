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
    public partial class FormInscripcion : Form
    {
        public FormInscripcion()
        {
            InitializeComponent();
        }

        private void comboCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            Servicios objServicios = new Servicios();
            txtCostoCurso.Text = objServicios.mostrarCosto(comboCurso.Text.ToLower()).ToString();
            txtSaldoCurso.Text = txtCostoCurso.Text;
            numPago.Maximum = Convert.ToInt32(txtCostoCurso.Text);
        }

        private void FormInscripcion_Load(object sender, EventArgs e)
        {
            try
            {
                Servicios objServicios = new Servicios();

                comboCurso.DataSource = objServicios.mostrarCurso();
                comboCurso.DisplayMember = "Nombre";
                comboCurso.ValueMember = "idCurso";

                txtSaldoCurso.Text = txtCostoCurso.Text;
                numPago.Maximum = Convert.ToInt32(txtCostoCurso.Text);

                lblUsuario.Text = "Usuario : " + objServicios.mostrarNombreCompletoUsuario(Program.clave).ToUpper();
                lblCargo.Text = "Cargo : " + objServicios.mostrarCargoUsuario(objServicios.mostrarNivelUsuario(Program.clave));
            }
            catch (Exception)
            {

            }
            
        }

        private void numPago_Validating(object sender, CancelEventArgs e)
        {

        }

        private void numPago_ValueChanged(object sender, EventArgs e)
        {
            int costo = Convert.ToInt32(txtCostoCurso.Text);
            int pago = (int)numPago.Value;
            txtSaldoCurso.Text = (costo - pago).ToString();
        }

        private void numPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            int costo = Convert.ToInt32(txtCostoCurso.Text);
            int pago = (int)numPago.Value;
            txtSaldoCurso.Text = (costo - pago).ToString();
        }

        private void txtCi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sw = true;
                txtCi.BackColor = Color.White;
                txtNombres.BackColor = Color.White;
                txtPaterno.BackColor = Color.White;
                txtMaterno.BackColor = Color.White;

                txtPaterno.Clear();
                txtMaterno.Clear();
                txtNombres.Clear();

                Servicios objServicios = new Servicios();
                int ci = Convert.ToInt32(txtCi.Text);
                dataEstudiantes.DataSource = objServicios.mostrarEstudiante(ci);
                dataEstudiantes.Refresh();

                if (dataEstudiantes.Rows.Count>1)
                {
                    dataEstudiantes.Visible = true;
                }
                else
                {
                    dataEstudiantes.Visible = false;
                }
               
            }
            catch
            {
                dataEstudiantes.Visible = false;
            }
        }

        public bool sw = true; 
        private void dataEstudiantes_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtCi.Text = dataEstudiantes.SelectedRows[0].Cells[0].Value.ToString();
                txtPaterno.Text = dataEstudiantes.SelectedRows[0].Cells[1].Value.ToString();
                txtMaterno.Text = dataEstudiantes.SelectedRows[0].Cells[2].Value.ToString();
                txtNombres.Text= dataEstudiantes.SelectedRows[0].Cells[3].Value.ToString();
                sw = false;

                txtCi.BackColor = Color.Yellow;
                txtNombres.BackColor = Color.Yellow;
                txtPaterno.BackColor = Color.Yellow;
                txtMaterno.BackColor = Color.Yellow;

                dataEstudiantes.Visible = false;
                MessageBox.Show("Estudiante ANTIGUO", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                dataEstudiantes.Visible = false;
            }
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            try
            {
                Inscripcion objInscripcion = new Inscripcion();
                objInscripcion.ciAdministrativo = Program.clave;
                objInscripcion.ciEstudiante = Convert.ToInt32(txtCi.Text.Trim());
                objInscripcion.idCurso = (int)comboCurso.SelectedValue;
                objInscripcion.pago = (short)numPago.Value;
                objInscripcion.ultimoUsuario = Program.clave;

                Servicios objServicios = new Servicios();
                if (sw)
                {
                    // ESTUDIANTE NUEVO
                    Estudiante ES = new Estudiante();
                    ES.ci = Convert.ToInt32(txtCi.Text.Trim());
                    ES.paterno = txtPaterno.Text.Trim();
                    ES.materno = txtMaterno.Text.Trim();
                    ES.nombres = txtNombres.Text.Trim();
                    ES.celular = Convert.ToInt32(txtCelular.Text.Trim());
                    ES.direccion = txtDireccion.Text.Trim();
                    ES.profesion = txtProfesion.Text.Trim();
                    ES.fechaNacimiento = dateFechaNacimiento.Value;
                    if (radioMasculino.Checked)
                        ES.genero = "m";
                    else
                        ES.genero = "f";

                    //A.ultimoUsuario = 9961393;
                    ES.ultimoUsuario = Program.clave;
                    if (objServicios.agregarInscripcion(objInscripcion, ES))
                    {
                        MessageBox.Show(objServicios.mostrarNombreCompletoUsuario(ES.ci).ToUpper() + " ha sido inscrito al curso: \n"+comboCurso.Text.ToUpper()+" satisfactoriamente!! ", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnInscribir.Enabled = false;
                    }
                }
                else
                    //ESTUDIANTE ANTIGUO   
                    if (objServicios.agregarInscripcion(objInscripcion))
                    MessageBox.Show("Inscripcion exiosa", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            btnInscribir.Enabled = true;
            txtCelular.Clear();
            txtCi.Clear();
            txtDireccion.Clear();
            txtMaterno.Clear();
            txtPaterno.Clear();
            txtProfesion.Clear();
            txtSaldoCurso.Clear();
            txtNombres.Clear();
            numPago.Value = 0;
        }

        private void btnVerCursos_Click(object sender, EventArgs e)
        {
            FormCursos f = new FormCursos();
            f.ShowDialog();
        }

        private void btnVerInscritos_Click(object sender, EventArgs e)
        {
            FormListaInscritos f = new FormListaInscritos();
            f.ShowDialog();
        }
    }
}
