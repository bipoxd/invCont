namespace invStore
{
    partial class FormArqueoApertura
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCajaInicial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOperador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFechaApertura = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHoraApertura = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caja Inicial";
            // 
            // txtCajaInicial
            // 
            this.txtCajaInicial.Location = new System.Drawing.Point(171, 42);
            this.txtCajaInicial.Name = "txtCajaInicial";
            this.txtCajaInicial.Size = new System.Drawing.Size(142, 22);
            this.txtCajaInicial.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Operador";
            // 
            // txtOperador
            // 
            this.txtOperador.Location = new System.Drawing.Point(171, 86);
            this.txtOperador.Name = "txtOperador";
            this.txtOperador.Size = new System.Drawing.Size(142, 22);
            this.txtOperador.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Apertura";
            // 
            // lblFechaApertura
            // 
            this.lblFechaApertura.AutoSize = true;
            this.lblFechaApertura.Location = new System.Drawing.Point(216, 137);
            this.lblFechaApertura.Name = "lblFechaApertura";
            this.lblFechaApertura.Size = new System.Drawing.Size(0, 16);
            this.lblFechaApertura.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hora Apertura";
            // 
            // lblHoraApertura
            // 
            this.lblHoraApertura.AutoSize = true;
            this.lblHoraApertura.Location = new System.Drawing.Point(204, 183);
            this.lblHoraApertura.Name = "lblHoraApertura";
            this.lblHoraApertura.Size = new System.Drawing.Size(0, 16);
            this.lblHoraApertura.TabIndex = 8;
            // 
            // FormArqueoApertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 275);
            this.Controls.Add(this.lblHoraApertura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblFechaApertura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOperador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCajaInicial);
            this.Controls.Add(this.label1);
            this.Name = "FormArqueoApertura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormArqueoApertura";
            this.Load += new System.EventHandler(this.FormArqueoApertura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCajaInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOperador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFechaApertura;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHoraApertura;
    }
}