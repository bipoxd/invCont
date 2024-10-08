using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace invStore
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormIngresarProductos ingp = new FormIngresarProductos();
            ingp.Show();
            this.Hide();
        }
        private void btn_IniciarERP_Click(object sender, EventArgs e)
        {
            FormERPventas erp = new FormERPventas();
            erp.Show();
            this.Hide();

        }
    }
}
