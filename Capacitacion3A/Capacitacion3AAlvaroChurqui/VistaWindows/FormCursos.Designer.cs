
namespace VistaWindows
{
    partial class FormCursos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label9 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevoDocente = new System.Windows.Forms.Button();
            this.txtDocente = new System.Windows.Forms.TextBox();
            this.numCosto = new System.Windows.Forms.NumericUpDown();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.numCargaHoraria = new System.Windows.Forms.NumericUpDown();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataDocentes = new System.Windows.Forms.DataGridView();
            this.dataCursos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dateFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.radioDisponibles = new System.Windows.Forms.RadioButton();
            this.radioFechaInicico = new System.Windows.Forms.RadioButton();
            this.radioTodos = new System.Windows.Forms.RadioButton();
            this.btnReporte = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCargaHoraria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDocentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCursos)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(519, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Bs.";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(498, 610);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(92, 38);
            this.btnLimpiar.TabIndex = 37;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(174, 610);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 38);
            this.btnGuardar.TabIndex = 36;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevoDocente
            // 
            this.btnNuevoDocente.Location = new System.Drawing.Point(523, 428);
            this.btnNuevoDocente.Name = "btnNuevoDocente";
            this.btnNuevoDocente.Size = new System.Drawing.Size(198, 40);
            this.btnNuevoDocente.TabIndex = 35;
            this.btnNuevoDocente.Text = "Agregar Nuevo Docente";
            this.btnNuevoDocente.UseVisualStyleBackColor = true;
            this.btnNuevoDocente.Click += new System.EventHandler(this.btnNuevoDocente_Click);
            // 
            // txtDocente
            // 
            this.txtDocente.Location = new System.Drawing.Point(174, 435);
            this.txtDocente.Name = "txtDocente";
            this.txtDocente.Size = new System.Drawing.Size(343, 26);
            this.txtDocente.TabIndex = 34;
            this.txtDocente.TextChanged += new System.EventHandler(this.txtDocente_TextChanged);
            // 
            // numCosto
            // 
            this.numCosto.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numCosto.Location = new System.Drawing.Point(395, 223);
            this.numCosto.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numCosto.Name = "numCosto";
            this.numCosto.Size = new System.Drawing.Size(120, 26);
            this.numCosto.TabIndex = 33;
            this.numCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(174, 326);
            this.txtHorario.Multiline = true;
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(521, 57);
            this.txtHorario.TabIndex = 32;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(174, 258);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(521, 62);
            this.txtDescripcion.TabIndex = 31;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Curso de capacitacion",
            "Seminario",
            "Taller"});
            this.cmbTipo.Location = new System.Drawing.Point(174, 180);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(183, 28);
            this.cmbTipo.TabIndex = 30;
            this.cmbTipo.Text = "Curso de capacitacion";
            // 
            // numCargaHoraria
            // 
            this.numCargaHoraria.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCargaHoraria.Location = new System.Drawing.Point(174, 223);
            this.numCargaHoraria.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numCargaHoraria.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numCargaHoraria.Name = "numCargaHoraria";
            this.numCargaHoraria.Size = new System.Drawing.Size(120, 26);
            this.numCargaHoraria.TabIndex = 29;
            this.numCargaHoraria.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCargaHoraria.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(174, 138);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(521, 30);
            this.txtNombre.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Docente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Costo: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Horario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Carga Horaria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Agregar Cursos";
            // 
            // dataDocentes
            // 
            this.dataDocentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataDocentes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDocentes.Location = new System.Drawing.Point(174, 490);
            this.dataDocentes.Name = "dataDocentes";
            this.dataDocentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDocentes.Size = new System.Drawing.Size(547, 158);
            this.dataDocentes.TabIndex = 39;
            this.dataDocentes.Visible = false;
            this.dataDocentes.DoubleClick += new System.EventHandler(this.dataDocentes_DoubleClick);
            // 
            // dataCursos
            // 
            this.dataCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCursos.Location = new System.Drawing.Point(756, 223);
            this.dataCursos.Name = "dataCursos";
            this.dataCursos.Size = new System.Drawing.Size(416, 326);
            this.dataCursos.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblCargo);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 67);
            this.panel1.TabIndex = 41;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(24, 26);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(51, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "label1";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(794, 26);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(51, 20);
            this.lblCargo.TabIndex = 1;
            this.lblCargo.Text = "label2";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1086, 6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(71, 61);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 395);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "Fecha de inicio";
            // 
            // dateFechaInicio
            // 
            this.dateFechaInicio.Location = new System.Drawing.Point(174, 389);
            this.dateFechaInicio.Name = "dateFechaInicio";
            this.dateFechaInicio.Size = new System.Drawing.Size(521, 26);
            this.dateFechaInicio.TabIndex = 43;
            // 
            // radioDisponibles
            // 
            this.radioDisponibles.AutoSize = true;
            this.radioDisponibles.Checked = true;
            this.radioDisponibles.Location = new System.Drawing.Point(6, 37);
            this.radioDisponibles.Name = "radioDisponibles";
            this.radioDisponibles.Size = new System.Drawing.Size(109, 24);
            this.radioDisponibles.TabIndex = 46;
            this.radioDisponibles.TabStop = true;
            this.radioDisponibles.Text = "Disponibles";
            this.radioDisponibles.UseVisualStyleBackColor = true;
            this.radioDisponibles.CheckedChanged += new System.EventHandler(this.radioDisponibles_CheckedChanged);
            // 
            // radioFechaInicico
            // 
            this.radioFechaInicico.AutoSize = true;
            this.radioFechaInicico.Location = new System.Drawing.Point(156, 37);
            this.radioFechaInicico.Name = "radioFechaInicico";
            this.radioFechaInicico.Size = new System.Drawing.Size(156, 24);
            this.radioFechaInicico.TabIndex = 47;
            this.radioFechaInicico.Text = "Por fecha de inicio";
            this.radioFechaInicico.UseVisualStyleBackColor = true;
            this.radioFechaInicico.CheckedChanged += new System.EventHandler(this.radioFechaInicico_CheckedChanged);
            // 
            // radioTodos
            // 
            this.radioTodos.AutoSize = true;
            this.radioTodos.Location = new System.Drawing.Point(339, 37);
            this.radioTodos.Name = "radioTodos";
            this.radioTodos.Size = new System.Drawing.Size(71, 24);
            this.radioTodos.TabIndex = 48;
            this.radioTodos.Text = "Todos";
            this.radioTodos.UseVisualStyleBackColor = true;
            this.radioTodos.CheckedChanged += new System.EventHandler(this.radioTodos_CheckedChanged);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(873, 180);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(191, 37);
            this.btnReporte.TabIndex = 49;
            this.btnReporte.Text = "Generar Reporte PDF";
            this.btnReporte.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioDisponibles);
            this.groupBox1.Controls.Add(this.radioFechaInicico);
            this.groupBox1.Controls.Add(this.radioTodos);
            this.groupBox1.Location = new System.Drawing.Point(728, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 67);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ver Cursos";
            // 
            // FormCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.dateFechaInicio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataCursos);
            this.Controls.Add(this.dataDocentes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevoDocente);
            this.Controls.Add(this.txtDocente);
            this.Controls.Add(this.numCosto);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.numCargaHoraria);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "FormCursos";
            this.Text = "FormCursos";
            this.Load += new System.EventHandler(this.FormCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCargaHoraria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDocentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCursos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevoDocente;
        private System.Windows.Forms.TextBox txtDocente;
        private System.Windows.Forms.NumericUpDown numCosto;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.NumericUpDown numCargaHoraria;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataDocentes;
        private System.Windows.Forms.DataGridView dataCursos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateFechaInicio;
        private System.Windows.Forms.RadioButton radioDisponibles;
        private System.Windows.Forms.RadioButton radioFechaInicico;
        private System.Windows.Forms.RadioButton radioTodos;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}