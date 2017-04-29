namespace Clase01
{
    partial class FormPrincipal
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
            this.lblUno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMas = new System.Windows.Forms.Label();
            this.lblDos = new System.Windows.Forms.Label();
            this.txtNumeroUno = new System.Windows.Forms.TextBox();
            this.txtNumeroDos = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUno
            // 
            this.lblUno.AutoSize = true;
            this.lblUno.Location = new System.Drawing.Point(25, 71);
            this.lblUno.Name = "lblUno";
            this.lblUno.Size = new System.Drawing.Size(53, 13);
            this.lblUno.TabIndex = 0;
            this.lblUno.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // lblMas
            // 
            this.lblMas.AutoSize = true;
            this.lblMas.Location = new System.Drawing.Point(134, 100);
            this.lblMas.Name = "lblMas";
            this.lblMas.Size = new System.Drawing.Size(13, 13);
            this.lblMas.TabIndex = 2;
            this.lblMas.Text = "+";
            // 
            // lblDos
            // 
            this.lblDos.AutoSize = true;
            this.lblDos.Location = new System.Drawing.Point(182, 71);
            this.lblDos.Name = "lblDos";
            this.lblDos.Size = new System.Drawing.Size(53, 13);
            this.lblDos.TabIndex = 3;
            this.lblDos.Text = "Numero 2";
            // 
            // txtNumeroUno
            // 
            this.txtNumeroUno.Location = new System.Drawing.Point(28, 97);
            this.txtNumeroUno.Name = "txtNumeroUno";
            this.txtNumeroUno.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroUno.TabIndex = 4;
            // 
            // txtNumeroDos
            // 
            this.txtNumeroDos.Location = new System.Drawing.Point(153, 97);
            this.txtNumeroDos.Name = "txtNumeroDos";
            this.txtNumeroDos.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroDos.TabIndex = 5;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(121, 140);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "&Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtResultado.Location = new System.Drawing.Point(28, 156);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(225, 46);
            this.txtResultado.TabIndex = 7;
            this.txtResultado.Enter += new System.EventHandler(this.txtResultado_Enter);
            this.txtResultado.Leave += new System.EventHandler(this.txtResultado_Leave);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(39, 208);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(72, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(160, 208);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.txtLimpiar_Click);
            // 
            // FormPrincipal
            // 
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnLimpiar;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtNumeroDos);
            this.Controls.Add(this.txtNumeroUno);
            this.Controls.Add(this.lblDos);
            this.Controls.Add(this.lblMas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUno);
            this.Name = "FormPrincipal";
            this.Text = "Formulario Simple";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMas;
        private System.Windows.Forms.Label lblDos;
        private System.Windows.Forms.TextBox txtNumeroUno;
        private System.Windows.Forms.TextBox txtNumeroDos;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

