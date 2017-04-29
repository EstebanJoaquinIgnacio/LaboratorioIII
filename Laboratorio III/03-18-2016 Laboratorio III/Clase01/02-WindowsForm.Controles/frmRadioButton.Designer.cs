namespace _02_WindowsForm.Controles
{
    partial class frmRadioButton
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.rbtRojo = new System.Windows.Forms.RadioButton();
            this.rbtAmarillo = new System.Windows.Forms.RadioButton();
            this.rbtVerde = new System.Windows.Forms.RadioButton();
            this.rbtComic = new System.Windows.Forms.RadioButton();
            this.rbtGaramond = new System.Windows.Forms.RadioButton();
            this.rbtTahoma = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(18, 160);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(268, 20);
            this.txtNombre.TabIndex = 13;
            this.txtNombre.Text = "Probando Controles de Opción";
            // 
            // rbtRojo
            // 
            this.rbtRojo.AutoSize = true;
            this.rbtRojo.BackColor = System.Drawing.Color.Red;
            this.rbtRojo.Location = new System.Drawing.Point(174, 99);
            this.rbtRojo.Name = "rbtRojo";
            this.rbtRojo.Size = new System.Drawing.Size(47, 17);
            this.rbtRojo.TabIndex = 12;
            this.rbtRojo.TabStop = true;
            this.rbtRojo.Text = "Rojo";
            this.rbtRojo.UseVisualStyleBackColor = false;
            this.rbtRojo.CheckedChanged += new System.EventHandler(this.rbtRojo_CheckedChanged);
            // 
            // rbtAmarillo
            // 
            this.rbtAmarillo.AutoSize = true;
            this.rbtAmarillo.BackColor = System.Drawing.Color.Yellow;
            this.rbtAmarillo.Location = new System.Drawing.Point(174, 76);
            this.rbtAmarillo.Name = "rbtAmarillo";
            this.rbtAmarillo.Size = new System.Drawing.Size(61, 17);
            this.rbtAmarillo.TabIndex = 11;
            this.rbtAmarillo.TabStop = true;
            this.rbtAmarillo.Text = "Amarillo";
            this.rbtAmarillo.UseVisualStyleBackColor = false;
            this.rbtAmarillo.CheckedChanged += new System.EventHandler(this.rbtAmarillo_CheckedChanged);
            // 
            // rbtVerde
            // 
            this.rbtVerde.AutoSize = true;
            this.rbtVerde.BackColor = System.Drawing.Color.Green;
            this.rbtVerde.Location = new System.Drawing.Point(174, 53);
            this.rbtVerde.Name = "rbtVerde";
            this.rbtVerde.Size = new System.Drawing.Size(53, 17);
            this.rbtVerde.TabIndex = 10;
            this.rbtVerde.TabStop = true;
            this.rbtVerde.Text = "Verde";
            this.rbtVerde.UseVisualStyleBackColor = false;
            this.rbtVerde.CheckedChanged += new System.EventHandler(this.rbtVerde_CheckedChanged);
            // 
            // rbtComic
            // 
            this.rbtComic.AutoSize = true;
            this.rbtComic.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtComic.Location = new System.Drawing.Point(49, 99);
            this.rbtComic.Name = "rbtComic";
            this.rbtComic.Size = new System.Drawing.Size(61, 22);
            this.rbtComic.TabIndex = 9;
            this.rbtComic.TabStop = true;
            this.rbtComic.Text = "Comic";
            this.rbtComic.UseVisualStyleBackColor = true;
            this.rbtComic.CheckedChanged += new System.EventHandler(this.rbtComic_CheckedChanged);
            // 
            // rbtGaramond
            // 
            this.rbtGaramond.AutoSize = true;
            this.rbtGaramond.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtGaramond.Location = new System.Drawing.Point(49, 76);
            this.rbtGaramond.Name = "rbtGaramond";
            this.rbtGaramond.Size = new System.Drawing.Size(81, 18);
            this.rbtGaramond.TabIndex = 8;
            this.rbtGaramond.TabStop = true;
            this.rbtGaramond.Text = "Garamond";
            this.rbtGaramond.UseVisualStyleBackColor = true;
            this.rbtGaramond.CheckedChanged += new System.EventHandler(this.rbtGaramond_CheckedChanged);
            // 
            // rbtTahoma
            // 
            this.rbtTahoma.AutoSize = true;
            this.rbtTahoma.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTahoma.Location = new System.Drawing.Point(49, 53);
            this.rbtTahoma.Name = "rbtTahoma";
            this.rbtTahoma.Size = new System.Drawing.Size(73, 20);
            this.rbtTahoma.TabIndex = 7;
            this.rbtTahoma.TabStop = true;
            this.rbtTahoma.Text = "Tahoma";
            this.rbtTahoma.UseVisualStyleBackColor = true;
            this.rbtTahoma.CheckedChanged += new System.EventHandler(this.rbtTahoma_CheckedChanged);
            // 
            // frmRadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 212);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.rbtRojo);
            this.Controls.Add(this.rbtAmarillo);
            this.Controls.Add(this.rbtVerde);
            this.Controls.Add(this.rbtComic);
            this.Controls.Add(this.rbtGaramond);
            this.Controls.Add(this.rbtTahoma);
            this.Name = "frmRadioButton";
            this.Text = "frmRadioButton";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.RadioButton rbtRojo;
        internal System.Windows.Forms.RadioButton rbtAmarillo;
        internal System.Windows.Forms.RadioButton rbtVerde;
        internal System.Windows.Forms.RadioButton rbtComic;
        internal System.Windows.Forms.RadioButton rbtGaramond;
        internal System.Windows.Forms.RadioButton rbtTahoma;
    }
}