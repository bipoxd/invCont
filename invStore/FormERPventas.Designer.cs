namespace invStore
{
    partial class FormERPventas
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
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnCerrarDia = new System.Windows.Forms.Button();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVenta
            // 
            this.btnVenta.Location = new System.Drawing.Point(12, 12);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(125, 34);
            this.btnVenta.TabIndex = 0;
            this.btnVenta.Text = "Iniciar Venta";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnCerrarDia
            // 
            this.btnCerrarDia.Location = new System.Drawing.Point(12, 52);
            this.btnCerrarDia.Name = "btnCerrarDia";
            this.btnCerrarDia.Size = new System.Drawing.Size(125, 34);
            this.btnCerrarDia.TabIndex = 1;
            this.btnCerrarDia.Text = "Cierre Dia";
            this.btnCerrarDia.UseVisualStyleBackColor = true;
            this.btnCerrarDia.Click += new System.EventHandler(this.btnCerrarDia_Click);
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.Location = new System.Drawing.Point(12, 311);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(125, 37);
            this.btnVolverMenu.TabIndex = 2;
            this.btnVolverMenu.Text = "Volver al Menu";
            this.btnVolverMenu.UseVisualStyleBackColor = true;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // FormERPventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.btnCerrarDia);
            this.Controls.Add(this.btnVenta);
            this.Name = "FormERPventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormERPventas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnCerrarDia;
        private System.Windows.Forms.Button btnVolverMenu;
    }
}