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
    public partial class FormAdministrativos : Form
    {
        public FormAdministrativos()
        {
            InitializeComponent();
        }

        private void FormAdministrativos_Load(object sender, EventArgs e)
        {
            Servicios objServicios = new Servicios();
            dataAdministrativos.DataSource = objServicios.mostrarAdministrativos();

            cmbCargo.DataSource = objServicios.listaCargos();
            //Validar Fecha de nacimiento
            DateTime x = DateTime.Now.AddYears(-17);
            dateFechaNacimiento.MaxDate = x;
            lblUsuario.Text = "Usuario : " + objServicios.mostrarNombreCompletoUsuario(Program.clave).ToUpper();
            lblCargo.Text = "Cargo : " + objServicios.mostrarCargoUsuario(objServicios.mostrarNivelUsuario(Program.clave));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Administrativo A = new Administrativo();
                A.ci = Convert.ToInt32(txtCi.Text.Trim());
                A.paterno = txtPaterno.Text.Trim();
                A.materno = txtMaterno.Text.Trim();
                A.nombres = txtNombres.Text.Trim();
                A.celular = Convert.ToInt32(txtCelular.Text.Trim());
                A.direccion = txtDireccion.Text.Trim();
                A.profesion = txtProfesion.Text.Trim();
                A.fechaNacimiento = dateFechaNacimiento.Value;
                A.cargo = cmbCargo.Text.Trim();

                //A.ultimoUsuario = 9961393;
                A.ultimoUsuario = Program.clave;

                Servicios objServicios = new Servicios();
                try
                {
                    if (objServicios.agregarAdministrativo(A))
                    {
                        MessageBox.Show(A.cargo.ToUpper() + " registrado correctamente!", "Confirmacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        btnGuardar.Enabled = false;
                        dataAdministrativos.DataSource = null;
                        dataAdministrativos.DataSource = objServicios.mostrarAdministrativos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Ingrese numeros validos al CI y CELULAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCelular.Clear();
            txtDireccion.Clear();
            txtCi.Clear();
            txtMaterno.Clear();
            txtNombres.Clear();
            txtPaterno.Clear();
            txtProfesion.Clear();

            btnGuardar.Enabled = true;
        }
    }
}
