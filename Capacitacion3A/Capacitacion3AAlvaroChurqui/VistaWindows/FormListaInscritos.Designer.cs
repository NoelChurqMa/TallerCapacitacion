
namespace VistaWindows
{
    partial class FormListaInscritos
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cmbTipoReporte = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxPorCurso = new System.Windows.Forms.GroupBox();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.btnGenerarPDF = new System.Windows.Forms.Button();
            this.dataListaInscritos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBoxPorCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaInscritos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Reporte de Estudiantes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.lblCargo);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 58);
            this.panel1.TabIndex = 26;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1112, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(70, 58);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(719, 12);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(60, 20);
            this.lblCargo.TabIndex = 1;
            this.lblCargo.Text = "label12";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(32, 12);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(60, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "label11";
            // 
            // cmbTipoReporte
            // 
            this.cmbTipoReporte.FormattingEnabled = true;
            this.cmbTipoReporte.Items.AddRange(new object[] {
            "Por CURSO",
            "Por GENERO",
            "Por FECHA",
            "Por PAGO",
            "Por TIPO DE CURSO"});
            this.cmbTipoReporte.Location = new System.Drawing.Point(39, 146);
            this.cmbTipoReporte.Name = "cmbTipoReporte";
            this.cmbTipoReporte.Size = new System.Drawing.Size(268, 28);
            this.cmbTipoReporte.TabIndex = 28;
            this.cmbTipoReporte.Text = "------Seleccionar----";
            this.cmbTipoReporte.SelectedIndexChanged += new System.EventHandler(this.cmbTipoReporte_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tipo de reporte: ";
            // 
            // groupBoxPorCurso
            // 
            this.groupBoxPorCurso.Controls.Add(this.cmbCurso);
            this.groupBoxPorCurso.Location = new System.Drawing.Point(418, 123);
            this.groupBoxPorCurso.Name = "groupBoxPorCurso";
            this.groupBoxPorCurso.Size = new System.Drawing.Size(743, 67);
            this.groupBoxPorCurso.TabIndex = 30;
            this.groupBoxPorCurso.TabStop = false;
            this.groupBoxPorCurso.Text = "Selccionar Curso";
            this.groupBoxPorCurso.Visible = false;
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(6, 25);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(721, 28);
            this.cmbCurso.TabIndex = 0;
            this.cmbCurso.SelectedIndexChanged += new System.EventHandler(this.cmbCurso_SelectedIndexChanged);
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(424, 196);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(233, 32);
            this.btnGenerarReporte.TabIndex = 1;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // btnGenerarPDF
            // 
            this.btnGenerarPDF.Location = new System.Drawing.Point(932, 196);
            this.btnGenerarPDF.Name = "btnGenerarPDF";
            this.btnGenerarPDF.Size = new System.Drawing.Size(213, 32);
            this.btnGenerarPDF.TabIndex = 2;
            this.btnGenerarPDF.Text = "PDF";
            this.btnGenerarPDF.UseVisualStyleBackColor = true;
            // 
            // dataListaInscritos
            // 
            this.dataListaInscritos.AllowUserToAddRows = false;
            this.dataListaInscritos.AllowUserToDeleteRows = false;
            this.dataListaInscritos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataListaInscritos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataListaInscritos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaInscritos.Location = new System.Drawing.Point(39, 302);
            this.dataListaInscritos.Name = "dataListaInscritos";
            this.dataListaInscritos.ReadOnly = true;
            this.dataListaInscritos.Size = new System.Drawing.Size(1122, 359);
            this.dataListaInscritos.TabIndex = 31;
            // 
            // FormListaInscritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnGenerarPDF);
            this.Controls.Add(this.dataListaInscritos);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.groupBoxPorCurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTipoReporte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormListaInscritos";
            this.Text = "FormListaInscritos";
            this.Load += new System.EventHandler(this.FormListaInscritos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxPorCurso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataListaInscritos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cmbTipoReporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxPorCurso;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.Button btnGenerarPDF;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.DataGridView dataListaInscritos;
    }
}