namespace ModeloSegundoParcialLabIII
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnoConElNombreDelCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarAlumnosASSPNETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnoToolStripMenuItem,
            this.mostrarToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "mnuMenu";
            // 
            // alumnoToolStripMenuItem
            // 
            this.alumnoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.bajaToolStripMenuItem,
            this.modificacionToolStripMenuItem});
            this.alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            this.alumnoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.alumnoToolStripMenuItem.Text = "Alumno";
            this.alumnoToolStripMenuItem.Click += new System.EventHandler(this.alumnoToolStripMenuItem_Click);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnoToolStripMenuItem1,
            this.cursoToolStripMenuItem,
            this.alumnoConElNombreDelCursoToolStripMenuItem,
            this.mostrarAlumnosASSPNETToolStripMenuItem});
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.altaToolStripMenuItem.Text = "Alta";
            // 
            // bajaToolStripMenuItem
            // 
            this.bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            this.bajaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bajaToolStripMenuItem.Text = "Baja";
            // 
            // modificacionToolStripMenuItem
            // 
            this.modificacionToolStripMenuItem.Name = "modificacionToolStripMenuItem";
            this.modificacionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modificacionToolStripMenuItem.Text = "Modificacion";
            // 
            // alumnoToolStripMenuItem1
            // 
            this.alumnoToolStripMenuItem1.Name = "alumnoToolStripMenuItem1";
            this.alumnoToolStripMenuItem1.Size = new System.Drawing.Size(240, 22);
            this.alumnoToolStripMenuItem1.Text = "Alumno";
            // 
            // cursoToolStripMenuItem
            // 
            this.cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
            this.cursoToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.cursoToolStripMenuItem.Text = "Curso";
            // 
            // alumnoConElNombreDelCursoToolStripMenuItem
            // 
            this.alumnoConElNombreDelCursoToolStripMenuItem.Name = "alumnoConElNombreDelCursoToolStripMenuItem";
            this.alumnoConElNombreDelCursoToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.alumnoConElNombreDelCursoToolStripMenuItem.Text = "AlumnoConElNombreDelCurso";
            // 
            // mostrarAlumnosASSPNETToolStripMenuItem
            // 
            this.mostrarAlumnosASSPNETToolStripMenuItem.Name = "mostrarAlumnosASSPNETToolStripMenuItem";
            this.mostrarAlumnosASSPNETToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.mostrarAlumnosASSPNETToolStripMenuItem.Text = "MostrarAlumnosASPNET";
            this.mostrarAlumnosASSPNETToolStripMenuItem.Click += new System.EventHandler(this.mostrarAlumnosASSPNETToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnoConElNombreDelCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarAlumnosASSPNETToolStripMenuItem;
    }
}

