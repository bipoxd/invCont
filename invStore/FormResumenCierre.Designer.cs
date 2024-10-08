namespace invStore
{
    partial class FormResumenCierre
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
            this.btnAceptarResumen = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEfectivo = new System.Windows.Forms.Label();
            this.lblDebito = new System.Windows.Forms.Label();
            this.lblCredito = new System.Windows.Forms.Label();
            this.lblTotalVentas = new System.Windows.Forms.Label();
            this.lblMontoInicial = new System.Windows.Forms.Label();
            this.lblMontoApertura = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptarResumen
            // 
            this.btnAceptarResumen.Location = new System.Drawing.Point(146, 228);
            this.btnAceptarResumen.Name = "btnAceptarResumen";
            this.btnAceptarResumen.Size = new System.Drawing.Size(192, 33);
            this.btnAceptarResumen.TabIndex = 40;
            this.btnAceptarResumen.Text = "Aceptar";
            this.btnAceptarResumen.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 27;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(22, 25);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 16);
            this.lblFecha.TabIndex = 28;
            // 
            // lblEfectivo
            // 
            this.lblEfectivo.AutoSize = true;
            this.lblEfectivo.Location = new System.Drawing.Point(306, 84);
            this.lblEfectivo.Name = "lblEfectivo";
            this.lblEfectivo.Size = new System.Drawing.Size(0, 16);
            this.lblEfectivo.TabIndex = 29;
            // 
            // lblDebito
            // 
            this.lblDebito.AutoSize = true;
            this.lblDebito.Location = new System.Drawing.Point(26, 84);
            this.lblDebito.Name = "lblDebito";
            this.lblDebito.Size = new System.Drawing.Size(0, 16);
            this.lblDebito.TabIndex = 30;
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.Location = new System.Drawing.Point(188, 84);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(0, 16);
            this.lblCredito.TabIndex = 31;
            // 
            // lblTotalVentas
            // 
            this.lblTotalVentas.AutoSize = true;
            this.lblTotalVentas.Location = new System.Drawing.Point(24, 179);
            this.lblTotalVentas.Name = "lblTotalVentas";
            this.lblTotalVentas.Size = new System.Drawing.Size(0, 16);
            this.lblTotalVentas.TabIndex = 32;
            // 
            // lblMontoInicial
            // 
            this.lblMontoInicial.AutoSize = true;
            this.lblMontoInicial.Location = new System.Drawing.Point(188, 176);
            this.lblMontoInicial.Name = "lblMontoInicial";
            this.lblMontoInicial.Size = new System.Drawing.Size(0, 16);
            this.lblMontoInicial.TabIndex = 34;
            // 
            // lblMontoApertura
            // 
            this.lblMontoApertura.AutoSize = true;
            this.lblMontoApertura.Location = new System.Drawing.Point(306, 172);
            this.lblMontoApertura.Name = "lblMontoApertura";
            this.lblMontoApertura.Size = new System.Drawing.Size(0, 16);
            this.lblMontoApertura.TabIndex = 42;
            // 
            // FormResumenCierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 320);
            this.Controls.Add(this.lblMontoApertura);
            this.Controls.Add(this.btnAceptarResumen);
            this.Controls.Add(this.lblMontoInicial);
            this.Controls.Add(this.lblTotalVentas);
            this.Controls.Add(this.lblCredito);
            this.Controls.Add(this.lblDebito);
            this.Controls.Add(this.lblEfectivo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label5);
            this.Name = "FormResumenCierre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormResumenCierre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptarResumen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEfectivo;
        private System.Windows.Forms.Label lblDebito;
        private System.Windows.Forms.Label lblCredito;
        private System.Windows.Forms.Label lblTotalVentas;
        private System.Windows.Forms.Label lblMontoInicial;
        private System.Windows.Forms.Label lblMontoApertura;
    }
}