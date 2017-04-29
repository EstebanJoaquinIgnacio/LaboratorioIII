namespace Aplicacion_1
{
    partial class frmDatosAlumno
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
            this.pbFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtFoto
            // 
            this.txtFoto.ReadOnly = true;
            // 
            // txtDni
            // 
            this.txtDni.ReadOnly = true;
            // 
            // txtNombre
            // 
            this.txtNombre.ReadOnly = true;
            // 
            // txtApellido
            // 
            this.txtApellido.ReadOnly = true;
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(13, 209);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(268, 150);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 10;
            this.pbFoto.TabStop = false;
            // 
            // frmDatosAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 433);
            this.Controls.Add(this.pbFoto);
            this.Name = "frmDatosAlumno";
            this.Text = "frmDatosAlumno";
            this.Load += new System.EventHandler(this.frmDatosAlumno_Load);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.lblApellido, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.lblDni, 0);
            this.Controls.SetChildIndex(this.lblFoto, 0);
            this.Controls.SetChildIndex(this.txtFoto, 0);
            this.Controls.SetChildIndex(this.txtDni, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtApellido, 0);
            this.Controls.SetChildIndex(this.pbFoto, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFoto;
    }
}