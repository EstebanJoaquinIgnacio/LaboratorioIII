namespace Clase02
{
    partial class FrmAlumno
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
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.lvlLegajo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(12, 167);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(221, 20);
            this.txtLegajo.TabIndex = 6;
            // 
            // lvlLegajo
            // 
            this.lvlLegajo.AutoSize = true;
            this.lvlLegajo.Location = new System.Drawing.Point(33, 151);
            this.lvlLegajo.Name = "lvlLegajo";
            this.lvlLegajo.Size = new System.Drawing.Size(39, 13);
            this.lvlLegajo.TabIndex = 7;
            this.lvlLegajo.Text = "Legajo";
            // 
            // FrmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 262);
            this.Controls.Add(this.lvlLegajo);
            this.Controls.Add(this.txtLegajo);
            this.Name = "FrmAlumno";
            this.Text = "FrmAlumno";
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.txtLegajo, 0);
            this.Controls.SetChildIndex(this.lvlLegajo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label lvlLegajo;
    }
}