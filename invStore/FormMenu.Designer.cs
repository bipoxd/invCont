namespace invStore
{
    partial class FormMenu
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
            this.btnIngresarProductos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_IniciarERP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido que accion desea realizar";
            // 
            // btnIngresarProductos
            // 
            this.btnIngresarProductos.Location = new System.Drawing.Point(12, 44);
            this.btnIngresarProductos.Name = "btnIngresarProductos";
            this.btnIngresarProductos.Size = new System.Drawing.Size(150, 34);
            this.btnIngresarProductos.TabIndex = 1;
            this.btnIngresarProductos.Text = "Ingresar Productos";
            this.btnIngresarProductos.UseVisualStyleBackColor = true;
            this.btnIngresarProductos.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(629, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Control de Inventario";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_IniciarERP
            // 
            this.btn_IniciarERP.Location = new System.Drawing.Point(311, 44);
            this.btn_IniciarERP.Name = "btn_IniciarERP";
            this.btn_IniciarERP.Size = new System.Drawing.Size(150, 34);
            this.btn_IniciarERP.TabIndex = 3;
            this.btn_IniciarERP.Text = "Iniciar ERP";
            this.btn_IniciarERP.UseVisualStyleBackColor = true;
            this.btn_IniciarERP.Click += new System.EventHandler(this.btn_IniciarERP_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_IniciarERP);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnIngresarProductos);
            this.Controls.Add(this.label1);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresarProductos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_IniciarERP;
    }
}