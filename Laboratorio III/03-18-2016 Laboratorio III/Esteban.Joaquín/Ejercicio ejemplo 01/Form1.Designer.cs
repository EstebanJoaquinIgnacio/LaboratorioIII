namespace Ejercicio_ejemplo_01
{
    partial class Form1
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnBoton = new System.Windows.Forms.Button();
            this.brnOtroFormulario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(206, 29);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(85, 64);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "&Mostrar Mensaje";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(0, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(35, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "label1";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // btnBoton
            // 
            this.btnBoton.Location = new System.Drawing.Point(100, 125);
            this.btnBoton.Name = "btnBoton";
            this.btnBoton.Size = new System.Drawing.Size(100, 53);
            this.btnBoton.TabIndex = 3;
            this.btnBoton.Text = "Mostrar Hola";
            this.btnBoton.UseVisualStyleBackColor = true;
            this.btnBoton.Click += new System.EventHandler(this.button2_Click);
            // 
            // brnOtroFormulario
            // 
            this.brnOtroFormulario.Location = new System.Drawing.Point(12, 209);
            this.brnOtroFormulario.Name = "brnOtroFormulario";
            this.brnOtroFormulario.Size = new System.Drawing.Size(161, 23);
            this.brnOtroFormulario.TabIndex = 4;
            this.brnOtroFormulario.Text = "button1";
            this.brnOtroFormulario.UseVisualStyleBackColor = true;
            this.brnOtroFormulario.Click += new System.EventHandler(this.brnOtroFormulario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.brnOtroFormulario);
            this.Controls.Add(this.btnBoton);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnMostrar);
            this.Name = "Form1";
            this.Text = "Mostrar Otro Formulario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBoton;
        private System.Windows.Forms.Button brnOtroFormulario;
    }
}

