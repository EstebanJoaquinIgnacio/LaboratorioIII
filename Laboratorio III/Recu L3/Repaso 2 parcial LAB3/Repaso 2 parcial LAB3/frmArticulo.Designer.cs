namespace frmPrincipal
{
    partial class frmArticulo
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tbxMarca = new System.Windows.Forms.TextBox();
            this.tbxPrecioVenta = new System.Windows.Forms.TextBox();
            this.tbxStock = new System.Windows.Forms.TextBox();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(45, 206);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(172, 205);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tbxMarca
            // 
            this.tbxMarca.Location = new System.Drawing.Point(31, 24);
            this.tbxMarca.Name = "tbxMarca";
            this.tbxMarca.Size = new System.Drawing.Size(100, 20);
            this.tbxMarca.TabIndex = 2;
            // 
            // tbxPrecioVenta
            // 
            this.tbxPrecioVenta.Location = new System.Drawing.Point(31, 66);
            this.tbxPrecioVenta.Name = "tbxPrecioVenta";
            this.tbxPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.tbxPrecioVenta.TabIndex = 3;
            // 
            // tbxStock
            // 
            this.tbxStock.Location = new System.Drawing.Point(31, 108);
            this.tbxStock.Name = "tbxStock";
            this.tbxStock.Size = new System.Drawing.Size(100, 20);
            this.tbxStock.TabIndex = 4;
            // 
            // cbxTipo
            // 
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbxTipo.Location = new System.Drawing.Point(31, 149);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(121, 21);
            this.cbxTipo.TabIndex = 5;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(31, 5);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca";
            this.lblMarca.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Location = new System.Drawing.Point(31, 51);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(83, 13);
            this.lblPrecioVenta.TabIndex = 7;
            this.lblPrecioVenta.Text = "Precio de Venta";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(31, 93);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(35, 13);
            this.lblStock.TabIndex = 8;
            this.lblStock.Text = "Stock";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(31, 135);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 9;
            this.lblTipo.Text = "Tipo";
            // 
            // frmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPrecioVenta);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.tbxStock);
            this.Controls.Add(this.tbxPrecioVenta);
            this.Controls.Add(this.tbxMarca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "frmArticulo";
            this.Text = "frmArticulo";
            this.Load += new System.EventHandler(this.frmArticulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox tbxMarca;
        private System.Windows.Forms.TextBox tbxPrecioVenta;
        private System.Windows.Forms.TextBox tbxStock;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblTipo;
    }
}