namespace Calculadora
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(12, 27);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDisplay.Size = new System.Drawing.Size(262, 70);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // btnUno
            // 
            this.btnUno.Location = new System.Drawing.Point(12, 141);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(40, 40);
            this.btnUno.TabIndex = 1;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnDos
            // 
            this.btnDos.Location = new System.Drawing.Point(58, 141);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(40, 40);
            this.btnDos.TabIndex = 2;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = true;
            this.btnDos.Click += new System.EventHandler(this.btnDos_Click);
            // 
            // btnTres
            // 
            this.btnTres.Location = new System.Drawing.Point(104, 141);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(40, 40);
            this.btnTres.TabIndex = 3;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnCuatro
            // 
            this.btnCuatro.Location = new System.Drawing.Point(12, 187);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(40, 40);
            this.btnCuatro.TabIndex = 4;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = true;
            this.btnCuatro.Click += new System.EventHandler(this.btnCuatro_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.Location = new System.Drawing.Point(58, 187);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(40, 40);
            this.btnCinco.TabIndex = 5;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.Location = new System.Drawing.Point(104, 187);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(40, 40);
            this.btnSeis.TabIndex = 6;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnSiete
            // 
            this.btnSiete.Location = new System.Drawing.Point(12, 233);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(40, 40);
            this.btnSiete.TabIndex = 7;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = true;
            this.btnSiete.Click += new System.EventHandler(this.btnSiete_Click);
            // 
            // btnOcho
            // 
            this.btnOcho.Location = new System.Drawing.Point(58, 233);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(40, 40);
            this.btnOcho.TabIndex = 8;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = true;
            this.btnOcho.Click += new System.EventHandler(this.btnOcho_Click);
            // 
            // btnNueve
            // 
            this.btnNueve.Location = new System.Drawing.Point(104, 233);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(40, 40);
            this.btnNueve.TabIndex = 9;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = true;
            this.btnNueve.Click += new System.EventHandler(this.btnNueve_Click);
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(150, 141);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(59, 59);
            this.btnSumar.TabIndex = 10;
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = true;
            // 
            // btnRestar
            // 
            this.btnRestar.Location = new System.Drawing.Point(150, 214);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(59, 59);
            this.btnRestar.TabIndex = 11;
            this.btnRestar.Text = "-";
            this.btnRestar.UseVisualStyleBackColor = true;
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(215, 141);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(59, 59);
            this.btnDividir.TabIndex = 12;
            this.btnDividir.Text = "%";
            this.btnDividir.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(215, 214);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(59, 59);
            this.btnMultiplicar.TabIndex = 13;
            this.btnMultiplicar.Text = "X";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(150, 279);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(124, 29);
            this.btnIgual.TabIndex = 14;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            // 
            // btnCero
            // 
            this.btnCero.Location = new System.Drawing.Point(12, 279);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(132, 29);
            this.btnCero.TabIndex = 15;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = true;
            this.btnCero.Click += new System.EventHandler(this.btnCero_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.White;
            this.btnReiniciar.Location = new System.Drawing.Point(13, 102);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(85, 33);
            this.btnReiniciar.TabIndex = 16;
            this.btnReiniciar.Text = "BORRAR";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(104, 102);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(170, 33);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "------------------>";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Calculadora.Properties.Resources.calcu;
            this.ClientSize = new System.Drawing.Size(279, 312);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnCero);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.btnNueve);
            this.Controls.Add(this.btnOcho);
            this.Controls.Add(this.btnSiete);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnCuatro);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnClear;
    }
}

