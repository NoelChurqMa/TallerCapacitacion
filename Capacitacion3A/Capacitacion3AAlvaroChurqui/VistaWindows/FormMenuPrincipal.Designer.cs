
namespace VistaWindows
{
    partial class FormMenuPrincipal
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdministrativo = new System.Windows.Forms.Button();
            this.btnCursos = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.lblCargo.Location = new System.Drawing.Point(384, 26);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(51, 20);
            this.lblCargo.TabIndex = 1;
            this.lblCargo.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblCargo);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 67);
            this.panel1.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(598, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(71, 61);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu Principal";
            // 
            // btnAdministrativo
            // 
            this.btnAdministrativo.Location = new System.Drawing.Point(12, 137);
            this.btnAdministrativo.Name = "btnAdministrativo";
            this.btnAdministrativo.Size = new System.Drawing.Size(181, 72);
            this.btnAdministrativo.TabIndex = 5;
            this.btnAdministrativo.Text = "Administrativo";
            this.btnAdministrativo.UseVisualStyleBackColor = true;
            this.btnAdministrativo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCursos
            // 
            this.btnCursos.Location = new System.Drawing.Point(257, 137);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(181, 72);
            this.btnCursos.TabIndex = 6;
            this.btnCursos.Text = "Curso de Capacitacion";
            this.btnCursos.UseVisualStyleBackColor = true;
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(491, 137);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(181, 72);
            this.button4.TabIndex = 7;
            this.button4.Text = "Inscripcion";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 233);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(181, 72);
            this.button5.TabIndex = 8;
            this.button5.Text = "Reportes";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(257, 233);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(181, 72);
            this.button6.TabIndex = 9;
            this.button6.Text = "Docentes";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(491, 233);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(181, 72);
            this.button7.TabIndex = 10;
            this.button7.Text = "Estudiantes";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnCursos);
            this.Controls.Add(this.btnAdministrativo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(700, 400);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "FormMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuPrincipal";
            this.Load += new System.EventHandler(this.FormMenuPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdministrativo;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}