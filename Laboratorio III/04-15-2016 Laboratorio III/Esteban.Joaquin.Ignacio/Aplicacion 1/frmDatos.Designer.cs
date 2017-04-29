namespace Aplicacion_1
{
    partial class frmDatos
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
            this.lblDatos = new System.Windows.Forms.Label();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(114, 239);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(35, 13);
            this.lblDatos.TabIndex = 0;
            this.lblDatos.Text = "label1";
            this.lblDatos.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbxFoto
            // 
            this.pbxFoto.Location = new System.Drawing.Point(12, 12);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(260, 211);
            this.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFoto.TabIndex = 1;
            this.pbxFoto.TabStop = false;
            this.pbxFoto.Click += new System.EventHandler(this.pbxFoto_Click);
            // 
            // frmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pbxFoto);
            this.Controls.Add(this.lblDatos);
            this.Name = "frmDatos";
            this.Text = "Datos";
            this.Load += new System.EventHandler(this.frmDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.PictureBox pbxFoto;
    }
}