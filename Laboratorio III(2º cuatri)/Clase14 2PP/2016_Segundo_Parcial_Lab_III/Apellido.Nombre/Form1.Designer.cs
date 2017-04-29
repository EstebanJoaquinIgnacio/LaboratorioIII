namespace Apellido.Nombre
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPunto1 = new System.Windows.Forms.Button();
            this.btnPunto2 = new System.Windows.Forms.Button();
            this.btnPunto3 = new System.Windows.Forms.Button();
            this.btnPunto4 = new System.Windows.Forms.Button();
            this.btnPunto5 = new System.Windows.Forms.Button();
            this.btnPunto6 = new System.Windows.Forms.Button();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.btnSincronizar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cboPerfiles = new System.Windows.Forms.ComboBox();
            this.lblPromedioEdad = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPunto1
            // 
            this.btnPunto1.Location = new System.Drawing.Point(12, 12);
            this.btnPunto1.Name = "btnPunto1";
            this.btnPunto1.Size = new System.Drawing.Size(75, 23);
            this.btnPunto1.TabIndex = 0;
            this.btnPunto1.Text = "Punto 1";
            this.btnPunto1.UseVisualStyleBackColor = true;
            this.btnPunto1.Click += new System.EventHandler(this.btnPunto1_Click);
            // 
            // btnPunto2
            // 
            this.btnPunto2.Location = new System.Drawing.Point(93, 12);
            this.btnPunto2.Name = "btnPunto2";
            this.btnPunto2.Size = new System.Drawing.Size(75, 23);
            this.btnPunto2.TabIndex = 1;
            this.btnPunto2.Text = "Punto 2";
            this.btnPunto2.UseVisualStyleBackColor = true;
            this.btnPunto2.Click += new System.EventHandler(this.btnPunto2_Click);
            // 
            // btnPunto3
            // 
            this.btnPunto3.Location = new System.Drawing.Point(174, 12);
            this.btnPunto3.Name = "btnPunto3";
            this.btnPunto3.Size = new System.Drawing.Size(75, 23);
            this.btnPunto3.TabIndex = 2;
            this.btnPunto3.Text = "Punto 3";
            this.btnPunto3.UseVisualStyleBackColor = true;
            this.btnPunto3.Click += new System.EventHandler(this.btnPunto3_Click);
            // 
            // btnPunto4
            // 
            this.btnPunto4.Location = new System.Drawing.Point(255, 12);
            this.btnPunto4.Name = "btnPunto4";
            this.btnPunto4.Size = new System.Drawing.Size(75, 23);
            this.btnPunto4.TabIndex = 3;
            this.btnPunto4.Text = "Punto 4";
            this.btnPunto4.UseVisualStyleBackColor = true;
            this.btnPunto4.Click += new System.EventHandler(this.btnPunto4_Click);
            // 
            // btnPunto5
            // 
            this.btnPunto5.Location = new System.Drawing.Point(336, 12);
            this.btnPunto5.Name = "btnPunto5";
            this.btnPunto5.Size = new System.Drawing.Size(75, 23);
            this.btnPunto5.TabIndex = 4;
            this.btnPunto5.Text = "Punto 5";
            this.btnPunto5.UseVisualStyleBackColor = true;
            this.btnPunto5.Click += new System.EventHandler(this.btnPunto5_Click);
            // 
            // btnPunto6
            // 
            this.btnPunto6.Location = new System.Drawing.Point(417, 12);
            this.btnPunto6.Name = "btnPunto6";
            this.btnPunto6.Size = new System.Drawing.Size(75, 23);
            this.btnPunto6.TabIndex = 5;
            this.btnPunto6.Text = "Punto 6";
            this.btnPunto6.UseVisualStyleBackColor = true;
            this.btnPunto6.Click += new System.EventHandler(this.btnPunto6_Click);
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(12, 55);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.Size = new System.Drawing.Size(480, 150);
            this.dgvGrilla.TabIndex = 6;
            // 
            // btnSincronizar
            // 
            this.btnSincronizar.Location = new System.Drawing.Point(498, 55);
            this.btnSincronizar.Name = "btnSincronizar";
            this.btnSincronizar.Size = new System.Drawing.Size(141, 23);
            this.btnSincronizar.TabIndex = 7;
            this.btnSincronizar.Text = "Sincronizar BD";
            this.btnSincronizar.UseVisualStyleBackColor = true;
            this.btnSincronizar.Click += new System.EventHandler(this.btnSincronizar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(498, 149);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(141, 23);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cboPerfiles
            // 
            this.cboPerfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPerfiles.FormattingEnabled = true;
            this.cboPerfiles.Location = new System.Drawing.Point(498, 122);
            this.cboPerfiles.Name = "cboPerfiles";
            this.cboPerfiles.Size = new System.Drawing.Size(141, 21);
            this.cboPerfiles.TabIndex = 9;
            // 
            // lblPromedioEdad
            // 
            this.lblPromedioEdad.AutoSize = true;
            this.lblPromedioEdad.Location = new System.Drawing.Point(498, 192);
            this.lblPromedioEdad.Name = "lblPromedioEdad";
            this.lblPromedioEdad.Size = new System.Drawing.Size(97, 13);
            this.lblPromedioEdad.TabIndex = 10;
            this.lblPromedioEdad.Text = "Promedio de Edad:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(627, 236);
            this.dataGridView1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 460);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblPromedioEdad);
            this.Controls.Add(this.cboPerfiles);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSincronizar);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.btnPunto6);
            this.Controls.Add(this.btnPunto5);
            this.Controls.Add(this.btnPunto4);
            this.Controls.Add(this.btnPunto3);
            this.Controls.Add(this.btnPunto2);
            this.Controls.Add(this.btnPunto1);
            this.Name = "Form1";
            this.Text = "Segundo Parcial Laboratorio III";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPunto1;
        private System.Windows.Forms.Button btnPunto2;
        private System.Windows.Forms.Button btnPunto3;
        private System.Windows.Forms.Button btnPunto4;
        private System.Windows.Forms.Button btnPunto5;
        private System.Windows.Forms.Button btnPunto6;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.Button btnSincronizar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cboPerfiles;
        private System.Windows.Forms.Label lblPromedioEdad;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

