namespace Aplicacion_1
{
    partial class frmTestDelegados
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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtTextDelegados = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(68, 89);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(110, 23);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // txtTextDelegados
            // 
            this.txtTextDelegados.Location = new System.Drawing.Point(68, 46);
            this.txtTextDelegados.Name = "txtTextDelegados";
            this.txtTextDelegados.Size = new System.Drawing.Size(110, 20);
            this.txtTextDelegados.TabIndex = 1;
            // 
            // frmTestDelegados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 143);
            this.Controls.Add(this.txtTextDelegados);
            this.Controls.Add(this.btnActualizar);
            this.Name = "frmTestDelegados";
            this.Text = "frmTestDelegados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtTextDelegados;

    }
}