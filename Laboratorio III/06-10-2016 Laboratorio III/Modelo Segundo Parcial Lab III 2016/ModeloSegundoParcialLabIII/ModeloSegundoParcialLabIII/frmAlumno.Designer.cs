namespace ModeloSegundoParcialLabIII
{
    partial class frmAlumno
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.cbbCurso = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbCurso);
            this.groupBox1.Controls.Add(this.txtLegajo);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.lblCurso);
            this.groupBox1.Controls.Add(this.lblLegajo);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Location = new System.Drawing.Point(25, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Alumno";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(39, 207);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(187, 207);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(49, 33);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(49, 72);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(42, 13);
            this.lblLegajo.TabIndex = 3;
            this.lblLegajo.Text = "Legajo:";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(49, 111);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(37, 13);
            this.lblCurso.TabIndex = 4;
            this.lblCurso.Text = "Curso:";
            this.lblCurso.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(52, 49);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(121, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(52, 88);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(121, 20);
            this.txtLegajo.TabIndex = 6;
            // 
            // cbbCurso
            // 
            this.cbbCurso.FormattingEnabled = true;
            this.cbbCurso.Location = new System.Drawing.Point(52, 127);
            this.cbbCurso.Name = "cbbCurso";
            this.cbbCurso.Size = new System.Drawing.Size(121, 21);
            this.cbbCurso.TabIndex = 7;
            // 
            // frmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAlumno";
            this.Text = "frmAlumno";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbCurso;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}